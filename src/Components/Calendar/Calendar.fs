namespace App
namespace Components

module Calendar =
    open Feliz
    open System
    open Fable.DateFunctions
    open System

    type Day = {
        DayOfWeek: System.DayOfWeek
        WeekNumber: int
    }

    type Week = {
        Days: Day list
    }

    type Month = {
        Name: string
        NumberOfDays: int
        MonthNumber: int
        Year: int
        Weeks: Week list
    }

    
    type Calendar = {
        Months: Month list
    }
    
    type MarkedDay = MarkedDay | UnMarkedDay

    type DayCard = 
        | EmptyDay
        | Day of (int * MarkedDay)

    type EventCard = {
        TimeStamp: string
        Title: string
        Description: string
    }

    let getWeekNumber (date: System.DateTime) =
        let mutable firstOfMonth = DateTime(date.Year, date.Month, 1)
        let mutable firstMondayOfMonth = firstOfMonth.AddDays(((int DayOfWeek.Monday) + 7 - (int firstOfMonth.DayOfWeek)) % 7)
        if (firstMondayOfMonth > date) 
        then
            firstOfMonth <- firstOfMonth.AddMonths(-1)
            firstMondayOfMonth <- firstMondayOfMonth.AddDays(((int DayOfWeek.Monday) + 7 - (int firstMondayOfMonth.DayOfWeek)) % 7)
        (date - firstMondayOfMonth).Days / 7 + 1

    let createDay (date: System.DateTime) =  
        { 
            DayOfWeek = date.DayOfWeek; 
            WeekNumber = getWeekNumber date
        }
    


    [<ReactComponent>]
    let Small() =
        let days = [ 
            "Mo" 
            "Tu" 
            "We" 
            "Th" 
            "Fr" 
            "Sa" 
            "Su" 
        ]

        let renderDayTitle (day: string) = 
            Html.th [
                prop.children [
                    Html.div [
                        prop.classes [ "w-full flex justify-center" ]
                        prop.children [
                            Html.p [
                                prop.classes [ "text-base font-medium text-center text-gray-800 dark:text-gray-100" ]
                                prop.text day
                            ]
                        ]
                    ]
                ]
            ]

        let renderEmptyDay () = 
            Html.td [
                prop.classes [ "pt-6" ]
                prop.children [
                    Html.div [
                        prop.classes [ "px-4 py-4 cursor-pointer flex w-full justify-center" ]
                    ]
                ]
            ]

        let renderMarkedDay (day: string) = 
            Html.td [
                prop.classes [ "pt-4" ]
                prop.children [
                    Html.div [
                        prop.classes [ "w-full h-full" ]
                        prop.children [
                            Html.div [
                                prop.classes [ "flex items-center justify-center w-full rounded-full cursor-pointer" ]
                                prop.children [
                                    Html.p [
                                        prop.classes [ 
                                            "focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-700 
                                            focus:bg-indigo-500 hover:bg-indigo-500 text-base w-8 h-8 flex items-center 
                                            justify-center font-medium text-white bg-indigo-700 rounded-full" ]
                                        prop.text day
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
            ]

        let renderUnmarkedDay (day: string) = 
            Html.td [
                prop.classes [ "pt-4" ]
                prop.children [
                    Html.div [
                        prop.classes [ "px-1 py-1 cursor-pointer flex w-full justify-center" ]
                        prop.children [
                            Html.p [
                                prop.classes [ "text-base text-gray-500 dark:text-gray-100 font-medium" ]
                                prop.text day
                            ]
                        ]
                    ]
                ]
            ]
            
            
        let renderDay (day: DayCard) =
            match day with
            | EmptyDay -> renderEmptyDay()
            | DayCard.Day (d, marked) -> 
                match marked with
                | MarkedDay -> renderMarkedDay (string d)
                | UnMarkedDay -> renderUnmarkedDay (string d)
            

        let renderWeek (days: DayCard list) =
            Html.tr [
                seq { for day in days do yield (renderDay day) }
                |> prop.children
            ]

        let renderEventCard (event: EventCard) = 
            Html.div [
                prop.classes [ "border-b pb-4 border-gray-400 border-dashed pt-5" ]
                prop.children [
                    Html.p [
                        prop.classes [ "text-xs font-light leading-3 text-gray-500 dark:text-gray-300" ]
                        prop.text event.TimeStamp
                    ]
                    Html.p [
                        prop.classes [ "text-md font-medium leading-5 text-gray-800 dark:text-gray-100 pt-2" ]
                        prop.text event.Title
                    ]
                    if (String.IsNullOrEmpty event.Description) 
                    then Html.none
                    else 
                        Html.p [
                            prop.classes [ "text-sm pt-2 leading-4 leading-none text-gray-600 dark:text-gray-300" ]
                            prop.text event.Description
                        ]
                ]
            ]

        Html.div [
            prop.classes [ "flex items-center justify-center py-8 px-4"]
            prop.children [
                Html.div [
                    prop.classes [ "max-w-sm w-full shadow-lg"]
                    prop.children [
                        Html.div [
                            prop.classes [ "md:p-8 p-5 md:pt-10 md:pb-10  dark:bg-gray-800 bg-white rounded-t"]
                            prop.children [
                                Html.div [
                                    prop.classes [ "px-4 flex items-center justify-between"]
                                    prop.children [
                                        Html.h1 [
                                            prop.name "month-year-title"
                                            prop.classes [ "text-base font-bold dark:text-gray-100 text-gray-800" ]
                                            prop.text "October 2020"
                                        ]
                                        Html.div [
                                            prop.classes [ "flex items-center text-gray-800 dark:text-gray-100"]
                                            prop.children [
                                                Svg.svg [
                                                    svg.xmlns "http://www.w3.org/2000/svg"
                                                    svg.classes [ "icon icon-tabler icon-tabler-chevron-left" ]
                                                    svg.width 24
                                                    svg.height 24
                                                    svg.viewBox(0, 0, 24, 24)
                                                    svg.stroke "currentColor"
                                                    svg.strokeWidth 1.5
                                                    svg.fill "none"
                                                    Interop.svgAttribute "strokeLinecap" "round"
                                                    Interop.svgAttribute "strokeLinejoin" "round"
                                                    svg.children [
                                                        Svg.path [
                                                            svg.stroke "none"
                                                            svg.d "M0 0h24v24H0z"
                                                            svg.fill "none"
                                                        ]
                                                        Svg.polyline [
                                                            svg.points "15 6 9 12 15 18"
                                                        ]
                                                    ]
                                                ]
                                                Svg.svg [
                                                    svg.xmlns "http://www.w3.org/2000/svg"
                                                    svg.classes [ "icon icon-tabler ml-3 icon-tabler-chevron-right" ]
                                                    svg.width 24
                                                    svg.height 24
                                                    svg.viewBox(0, 0, 24, 24)
                                                    svg.stroke "currentColor"
                                                    svg.strokeWidth 1.5
                                                    svg.fill "none"
                                                    Interop.svgAttribute "strokeLinecap" "round"
                                                    Interop.svgAttribute "strokeLinejoin" "round"
                                                    svg.children [
                                                        Svg.path [
                                                            svg.stroke "none"
                                                            svg.d "M0 0h24v24H0z"
                                                            svg.fill "none"
                                                        ]
                                                        Svg.polyline [
                                                            svg.points "9 6 15 12 9 18"
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "flex items-center justify-between pt-12 overflow-x-auto" ]
                                    prop.children [
                                        Html.table [
                                            prop.classes [ "w-full" ]
                                            prop.children [
                                                Html.thead [
                                                    prop.children [
                                                        Html.tr [
                                                            seq { for day in days do yield renderDayTitle day }
                                                            |> prop.children 
                                                        ]
                                                    ]
                                                ]
                                                Html.tbody [
                                                    prop.children [
                                                        renderWeek [ 
                                                            DayCard.EmptyDay; 
                                                            DayCard.EmptyDay; 
                                                            DayCard.EmptyDay;
                                                            DayCard.Day(1, UnMarkedDay)
                                                            DayCard.Day(2, UnMarkedDay)
                                                            DayCard.Day(3, MarkedDay)
                                                            DayCard.Day(4, UnMarkedDay)
                                                        ]
                                                        renderWeek [ for i in 5..11 -> DayCard.Day(i, UnMarkedDay) ]
                                                        renderWeek [ for i in 12..18 -> DayCard.Day(i, UnMarkedDay) ]
                                                        renderWeek [ for i in 19..25 -> DayCard.Day(i, UnMarkedDay) ]
                                                        renderWeek [ 
                                                            for i in 26..32 -> (
                                                                if i > 30 
                                                                then DayCard.EmptyDay 
                                                                else DayCard.Day(i, UnMarkedDay)
                                                            ) 
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.classes [ "md:p-8 py-5 md:px-8 px-5 md:pb-10 dark:bg-gray-700 bg-gray-50 rounded-b" ]
                            prop.children [
                                Html.div [
                                    prop.classes [ "px-4" ]
                                    [
                                        {
                                            TimeStamp = "9:00 AM"
                                            Title = "Zoom call with design team"
                                            Description = "Discussion on UX sprint and Wireframe review"
                                        }
                                        {
                                            TimeStamp = "10:00 AM"
                                            Title = "Orientation session with new hires"
                                            Description = ""
                                        }
                                        {
                                            TimeStamp = "11:00 AM"
                                            Title = "Zoom call with design team"
                                            Description = "Discussion on UX sprint and Wireframe review"
                                        }
                                    ]
                                    |> Seq.map renderEventCard
                                    |> prop.children
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]