namespace App
namespace Components

module Search =
    open Feliz
    open Browser.Dom
    open Browser.Types
    open Fable.Core.JsInterop

    [<ReactComponent>]
    let Small() = 

        React.useEffect(fun () -> ());

        let showDropDownMenu  = 
            fun (el: MouseEvent) -> 
                (el.target:?>HTMLElement)
                    .parentElement
                    .children[1]
                    .classList
                    .toggle("hidden")
                    |> ignore

        let swapText = 
            fun (el: MouseEvent) ->
                let targetText = (el.target:?>HTMLElement).innerText
                document.getElementById("drop-down-content-setter").innerText <- targetText
                document.getElementById("drop-down-div")
                    .classList
                    .toggle("hidden")
                    |> ignore

        let showDropDownMenuOne  = 
            fun (el: MouseEvent) -> 
                (el.target:?>HTMLElement)
                    .parentElement
                    .children[1]
                    .classList
                    .toggle("hidden")
                    |> ignore

        let swapTextOne = 
            fun (el: MouseEvent) ->
                let targetText = (el.target:?>HTMLElement).innerText
                document.getElementById("drop-down-content-setter-one").innerText <- targetText
                document.getElementById("drop-down-div-one")
                    .classList
                    .toggle("hidden")
                    |> ignore

        let showDropDownMenuTwo  = 
            fun (el: MouseEvent) -> 
                (el.target:?>HTMLElement)
                    .parentElement
                    .children[1]
                    .classList
                    .toggle("hidden")
                    |> ignore

        let swapTextTwo = 
            fun (el: MouseEvent) ->
                let targetText = (el.target:?>HTMLElement).innerText
                document.getElementById("drop-down-content-setter-two").innerText <- targetText
                document.getElementById("drop-down-div-two")
                    .classList
                    .toggle("hidden")
                    |> ignore

        let plusMe = 
            fun (el: MouseEvent) ->
                let (currentEl: Element) = 
                    (el.target:?>HTMLElement)
                        .parentElement
                        .parentElement
                        .children[2]
                try
                    let currentValue = currentEl?innerText |> int
                    currentEl?innerText <- ((currentValue + 1000) |> string)
                with
                | ex -> ()

        let minusMe = 
            fun (el: MouseEvent) ->
                let (currentEl: Element) = 
                    (el.target:?>HTMLElement)
                        .parentElement
                        .parentElement
                        .children[2]
                try
                    let currentValue = currentEl?innerText |> int
                    if (currentValue > 0) 
                    then currentEl?innerText <- ((currentValue - 1000) |> string)
                with
                | ex -> ()


        Html.div [
            prop.children [
                Html.div [
                    prop.classes [ "py-12 px-4" ]
                ]
                Html.div [
                    prop.classes [ "bg-white lg:max-w-[384px] md:max-w-[720px] w-full shadow rounded mx-auto pb-10 px-6" ]
                    prop.children [
                        Html.div [
                            prop.classes [ "flex justify-start items-center py-7 relative" ]
                            prop.children [
                                Html.input [
                                    prop.classes [ "text-sm leading-none text-left text-gray-600 px-4 py-3 w-full border rounded border-gray-300  outline-none" ]
                                    prop.type'.text
                                    prop.placeholder "Search"
                                ]
                                Svg.svg [
                                    svg.xmlns "http://www.w3.org/2000/svg"
                                    svg.classes [ "absolute right-3 z-10 cursor-pointer" ]
                                    svg.width 24
                                    svg.height 24
                                    svg.viewBox(0, 0, 24, 24)
                                    svg.stroke "#FFFFFF"
                                    svg.fill "none"
                                    svg.children [
                                        Svg.path [
                                            svg.d "M10 17C13.866 17 17 13.866 17 10C17 6.13401 13.866 3 10 3C6.13401 3 3 6.13401 3 10C3 13.866 6.13401 17 10 17Z"
                                            svg.stroke "#4B5563"
                                            svg.strokeWidth 1.66667
                                            Interop.svgAttribute "strokeLinecap" "round"
                                            Interop.svgAttribute "strokeLinejoin" "round"
                                        ]
                                        Svg.path [
                                            svg.d "M21 21L15 15"
                                            svg.stroke "#4B5563"
                                            svg.strokeWidth 1.66667
                                            Interop.svgAttribute "strokeLinecap" "round"
                                            Interop.svgAttribute "strokeLinejoin" "round"
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Html.hr [
                            prop.classes [ "border-gray-100" ]
                        ]

                        // Team Name
                        Html.div [
                            prop.classes [ "mt-7 relative" ]
                            prop.children [
                                Html.p [
                                    prop.classes [ "text-sm text-left font-medium leading-none text-gray-800 mb-3" ]
                                    prop.text "Team Name"
                                ]
                                Html.div [
                                    prop.classes [ "flex justify-start items-center" ]
                                    prop.children [
                                        Html.input [
                                            prop.classes [ "text-sm leading-none text-left text-gray-600 px-4 py-3  w-full border rounded border-gray-300 relative outline-none" ]
                                            prop.type'.text
                                            prop.placeholder "For example “Alpha”"
                                        ]
                                    ]
                                ]
                            ]
                        ]

                        // Team Type
                        Html.div [
                            prop.classes [ "mt-8" ]
                            prop.children [
                                Html.label [
                                    prop.classes [ "text-sm text-left font-medium leading-none text-gray-800" ]
                                    prop.text "Team Type"
                                ]
                                Html.div [
                                    prop.classes [ "dropdown-one border border-gray-300 w-full rounded outline-none relative mt-2" ]
                                    prop.children [
                                        Html.button [
                                            prop.onClick (showDropDownMenu)
                                            prop.classes [ "dropbtn-one relative px-5 py-[12px] flex items-center justify-between w-full" ]
                                            prop.children [
                                                Html.span [
                                                    prop.classes [ "pr-4 font-medium text-gray-600 text-sm" ]
                                                    prop.id "drop-down-content-setter"
                                                    prop.text "Beginner"
                                                ]
                                                Svg.svg [
                                                    svg.xmlns "http://www.w3.org/2000/svg"
                                                    svg.classes [ "absolute right-5 z-10 cursor-pointer" ]
                                                    svg.width 10
                                                    svg.height 6
                                                    svg.viewBox(0, 0, 10, 6)
                                                    svg.fill "none"
                                                    svg.children [
                                                        Svg.path [
                                                            svg.d "M0.5 0.75L5 5.25L9.5 0.75"
                                                            svg.stroke "#4B5563"
                                                            Interop.svgAttribute "strokeLinecap" "round"
                                                            Interop.svgAttribute "strokeLinejoin" "round"
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.classes [ "hidden rounded w-full shadow border-t border-gray-200 px-1 py-2 absolute top-12 right-0 bg-white" ]
                                            prop.id "drop-down-div"
                                            prop.children [
                                                Html.a [
                                                    prop.href "javascript:void(0)"
                                                    prop.classes [ "hover" ]
                                                    prop.children [
                                                        Html.p [
                                                            prop.classes [ "text-sm leading-none text-gray-600 p-3 hover:bg-indigo-100 hover:font-medium hover:text-indigo-700 hover:rounded cursor-pointer" ]
                                                            prop.onClick (swapText)
                                                            prop.text "Beginner"
                                                        ]
                                                    ]
                                                ]
                                                Html.a [
                                                    prop.href "javascript:void(0)"
                                                    prop.classes [ "hover" ]
                                                    prop.children [
                                                        Html.p [
                                                            prop.classes [ "text-sm leading-none text-gray-600 p-3 hover:bg-indigo-100 hover:font-medium hover:text-indigo-700 hover:rounded cursor-pointer" ]
                                                            prop.onClick (swapText)
                                                            prop.text "Intermediate"
                                                        ]
                                                    ]
                                                ]
                                                Html.a [
                                                    prop.href "javascript:void(0)"
                                                    prop.classes [ "hover" ]
                                                    prop.children [
                                                        Html.p [
                                                            prop.classes [ "text-sm leading-none text-gray-600 p-3 hover:bg-indigo-100 hover:font-medium hover:text-indigo-700 hover:rounded cursor-pointer" ]
                                                            prop.onClick (swapText)
                                                            prop.text "Expert"
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]

                        // Team Size
                        Html.div [
                            prop.classes [ "mt-8 w-full" ]
                            prop.children [
                                Html.label [
                                    prop.classes [ "text-sm text-left font-medium leading-none text-gray-800" ]
                                    prop.text "Team Size"
                                ]
                                Html.div [
                                    prop.classes [ "flex justify-start items-center mt-2" ]
                                    prop.children [
                                        Html.div [
                                            prop.classes [ "flex justify-between  items-center w-full border rounded border-gray-300 md:px-6 px-3 py-1 lg:gap-x-2 md:gap-x-2 gap-x-2" ]
                                            prop.children [
                                                Html.button [
                                                    prop.classes [ "text-sm leading-none text-gray-600 p-3 hover:bg-indigo-100 hover:text-indigo-700 hover:rounded focus:bg-indigo-100 focus:text-indigo-700 focus:rounded w-[60px]" ]
                                                    prop.text "1-5"
                                                ]
                                                Html.button [
                                                    prop.classes [ "text-sm leading-none text-gray-600 p-3 hover:bg-indigo-100 hover:text-indigo-700 hover:rounded focus:bg-indigo-100 focus:text-indigo-700 focus:rounded w-[60px]" ]
                                                    prop.text "5-10"
                                                ]
                                                Html.button [
                                                    prop.classes [ "text-sm leading-none text-gray-600 p-3 hover:bg-indigo-100 hover:text-indigo-700 hover:rounded focus:bg-indigo-100 focus:text-indigo-700 focus:rounded w-[60px]" ]
                                                    prop.text "10-15"
                                                ]
                                                Html.button [
                                                    prop.classes [ "text-sm leading-none text-gray-600 p-3 hover:bg-indigo-100 hover:text-indigo-700 hover:rounded focus:bg-indigo-100 focus:text-indigo-700 focus:rounded w-[60px]" ]
                                                    prop.text "15+"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]

                        // Amount
                        Html.div [
                            prop.classes [ "mt-8" ]
                            prop.children [
                                Html.label [
                                    prop.classes [ "text-sm text-left font-medium leading-none text-gray-800" ]
                                    prop.text "Amount"
                                ]
                                Html.div [
                                    prop.classes [ "flex items-center border border-slate-300 px-4 py-3 rounded mt-2" ]
                                    prop.children [
                                        Html.div [
                                            prop.classes [ "svg-container" ]
                                            prop.children [
                                                Svg.svg [
                                                    svg.onClick (minusMe)
                                                    svg.xmlns "http://www.w3.org/2000/svg"
                                                    svg.classes [ "hover:bg-gray-100 cursor-pointer rounded-full" ]
                                                    svg.width 24
                                                    svg.height 24
                                                    svg.viewBox(0, 0, 24, 24)
                                                    svg.fill "none"
                                                    svg.children [
                                                        Svg.path [
                                                            svg.d "M21 12C21 7.03125 16.9688 3 12 3C7.03125 3 3 7.03125 3 12C3 16.9688 7.03125 21 12 21C16.9688 21 21 16.9688 21 12Z"
                                                            svg.stroke "#475569"
                                                            Interop.svgAttribute "strokeMiterlimit" 10
                                                        ]
                                                        Svg.path [
                                                            svg.d "M15.75 12H8.25"
                                                            svg.stroke "#475569"
                                                            Interop.svgAttribute "strokeLinecap" "round"
                                                            Interop.svgAttribute "strokeLinejoin" "round"
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.classes [ "dollar-container pl-4" ]
                                            prop.children [
                                                Html.p [
                                                    prop.classes [ "text-sm leading-none text-slate-600 pr-1" ]
                                                    prop.text "$"
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.classes [ "text-container w-full text-sm leading-none text-slate-600" ]
                                            prop.text "1000"
                                        ]
                                        Html.div [
                                            prop.classes [ "svg-container" ]
                                            prop.children [
                                                Svg.svg [
                                                    svg.onClick (plusMe)
                                                    svg.xmlns "http://www.w3.org/2000/svg"
                                                    svg.classes [ "hover:bg-gray-100 cursor-pointer rounded-full" ]
                                                    svg.width 24
                                                    svg.height 24
                                                    svg.viewBox(0, 0, 24, 24)
                                                    svg.fill "none"
                                                    svg.children [
                                                        Svg.path [
                                                            svg.d "M21 12C21 7.03125 16.9688 3 12 3C7.03125 3 3 7.03125 3 12C3 16.9688 7.03125 21 12 21C16.9688 21 21 16.9688 21 12Z"
                                                            svg.stroke "#475569"
                                                            Interop.svgAttribute "strokeMiterlimit" 10
                                                        ]
                                                        Svg.path [
                                                            svg.d "M12 8.25V15.75"
                                                            svg.stroke "#475569"
                                                            Interop.svgAttribute "strokeLinecap" "round"
                                                            Interop.svgAttribute "strokeLinejoin" "round"
                                                        ]
                                                        Svg.path [
                                                            svg.d "M15.75 12H8.25"
                                                            svg.stroke "#475569"
                                                            Interop.svgAttribute "strokeLinecap" "round"
                                                            Interop.svgAttribute "strokeLinejoin" "round"
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        
                        // Categories
                        Html.div [
                            prop.classes [ "mt-8" ]
                            prop.children [
                                Html.label [
                                    prop.classes [ "text-sm text-left font-medium leading-none text-gray-800" ]
                                    prop.text "Category"
                                ]
                                Html.div [
                                    prop.classes [ "dropdown-one border border-gray-300 w-full rounded outline-none relative mt-2" ]
                                    prop.children [
                                        Html.button [
                                            prop.onClick (showDropDownMenuOne)
                                            prop.classes [ "dropbtn-one relative px-5 py-[12px] flex items-center justify-between w-full" ]
                                            prop.children [
                                                Html.span [
                                                    prop.classes [ "pr-4 font-medium text-gray-600 text-sm" ]
                                                    prop.id "drop-down-content-setter-one"
                                                    prop.text "Q/A"
                                                ]
                                                Svg.svg [
                                                    svg.xmlns "http://www.w3.org/2000/svg"
                                                    svg.classes [ "absolute right-5 z-10 cursor-pointer" ]
                                                    svg.width 10
                                                    svg.height 6
                                                    svg.viewBox(0, 0, 10, 6)
                                                    svg.fill "none"
                                                    svg.children [
                                                        Svg.path [
                                                            svg.d "M0.5 0.75L5 5.25L9.5 0.75"
                                                            svg.stroke "#4B5563"
                                                            Interop.svgAttribute "strokeLinecap" "round"
                                                            Interop.svgAttribute "strokeLinejoin" "round"
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.classes [ "hidden rounded w-full shadow border-t border-gray-200 px-1 py-2 absolute top-12 right-0 bg-white z-20" ]
                                            prop.id "drop-down-div-one"
                                            prop.children [
                                                Html.a [
                                                    prop.href "javascript:void(0)"
                                                    prop.classes [ "hover" ]
                                                    prop.children [
                                                        Html.p [
                                                            prop.classes [ "text-sm leading-none text-gray-600 p-3 hover:bg-indigo-100 hover:font-medium hover:text-indigo-700 hover:rounded cursor-pointer" ]
                                                            prop.onClick (swapTextOne)
                                                            prop.text "Q/A"
                                                        ]
                                                    ]
                                                ]
                                                Html.a [
                                                    prop.href "javascript:void(0)"
                                                    prop.classes [ "hover" ]
                                                    prop.children [
                                                        Html.p [
                                                            prop.classes [ "text-sm leading-none text-gray-600 p-3 hover:bg-indigo-100 hover:font-medium hover:text-indigo-700 hover:rounded cursor-pointer" ]
                                                            prop.onClick (swapTextOne)
                                                            prop.text "Designing"
                                                        ]
                                                    ]
                                                ]
                                                Html.a [
                                                    prop.href "javascript:void(0)"
                                                    prop.classes [ "hover" ]
                                                    prop.children [
                                                        Html.p [
                                                            prop.classes [ "text-sm leading-none text-gray-600 p-3 hover:bg-indigo-100 hover:font-medium hover:text-indigo-700 hover:rounded cursor-pointer" ]
                                                            prop.onClick (swapTextOne)
                                                            prop.text "Developement"
                                                        ]
                                                    ]
                                                ]
                                                Html.a [
                                                    prop.href "javascript:void(0)"
                                                    prop.classes [ "hover" ]
                                                    prop.children [
                                                        Html.p [
                                                            prop.classes [ "text-sm leading-none text-gray-600 p-3 hover:bg-indigo-100 hover:font-medium hover:text-indigo-700 hover:rounded cursor-pointer" ]
                                                            prop.onClick (swapTextOne)
                                                            prop.text "Marketing"
                                                        ]
                                                    ]
                                                ]
                                                Html.a [
                                                    prop.href "javascript:void(0)"
                                                    prop.classes [ "hover" ]
                                                    prop.children [
                                                        Html.p [
                                                            prop.classes [ "text-sm leading-none text-gray-600 p-3 hover:bg-indigo-100 hover:font-medium hover:text-indigo-700 hover:rounded cursor-pointer" ]
                                                            prop.onClick (swapTextOne)
                                                            prop.text "Business Developement"
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]

                        // Group Types
                        Html.div [
                            prop.classes [ "mt-8" ]
                            prop.children [
                                Html.label [
                                    prop.classes [ "text-sm text-left font-medium leading-none text-gray-800" ]
                                    prop.text "Group Type"
                                ]
                                Html.div [
                                    prop.classes [ "dropdown-one border border-gray-300 w-full rounded outline-none relative mt-2" ]
                                    prop.children [
                                        Html.button [
                                            prop.onClick (showDropDownMenuTwo)
                                            prop.classes [ "dropbtn-one relative px-5 py-[12px] flex items-center justify-between w-full" ]
                                            prop.children [
                                                Html.span [
                                                    prop.classes [ "pr-4 font-medium text-gray-600 text-sm" ]
                                                    prop.id "drop-down-content-setter-two"
                                                    prop.text "All"
                                                ]
                                                Svg.svg [
                                                    svg.xmlns "http://www.w3.org/2000/svg"
                                                    svg.classes [ "absolute right-5 z-10 cursor-pointer" ]
                                                    svg.width 10
                                                    svg.height 6
                                                    svg.viewBox(0, 0, 10, 6)
                                                    svg.fill "none"
                                                    svg.children [
                                                        Svg.path [
                                                            svg.d "M0.5 0.75L5 5.25L9.5 0.75"
                                                            svg.stroke "#4B5563"
                                                            Interop.svgAttribute "strokeLinecap" "round"
                                                            Interop.svgAttribute "strokeLinejoin" "round"
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.classes [ "hidden rounded w-full shadow border-t border-gray-200 px-1 py-2 absolute top-12 right-0 bg-white z-10" ]
                                            prop.id "drop-down-div-two"
                                            prop.children [
                                                Html.a [
                                                    prop.href "javascript:void(0)"
                                                    prop.classes [ "hover" ]
                                                    prop.children [
                                                        Html.p [
                                                            prop.classes [ "text-sm leading-none text-gray-600 p-3 hover:bg-indigo-100 hover:font-medium hover:text-indigo-700 hover:rounded cursor-pointer" ]
                                                            prop.onClick (swapTextTwo)
                                                            prop.text "All"
                                                        ]
                                                    ]
                                                ]
                                                Html.a [
                                                    prop.href "javascript:void(0)"
                                                    prop.classes [ "hover" ]
                                                    prop.children [
                                                        Html.p [
                                                            prop.classes [ "text-sm leading-none text-gray-600 p-3 hover:bg-indigo-100 hover:font-medium hover:text-indigo-700 hover:rounded cursor-pointer" ]
                                                            prop.onClick (swapTextTwo)
                                                            prop.text "Users"
                                                        ]
                                                    ]
                                                ]
                                                Html.a [
                                                    prop.href "javascript:void(0)"
                                                    prop.classes [ "hover" ]
                                                    prop.children [
                                                        Html.p [
                                                            prop.classes [ "text-sm leading-none text-gray-600 p-3 hover:bg-indigo-100 hover:font-medium hover:text-indigo-700 hover:rounded cursor-pointer" ]
                                                            prop.onClick (swapTextTwo)
                                                            prop.text "Orders"
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]

                        // Buttons
                        Html.div [
                            prop.classes [ "lg:flex justify-end mr-1 items-center gap-x-3 mt-12 lg:block md:hidden hidden" ]
                            prop.children [
                                Html.button [
                                    prop.classes [ "text-sm font-medium leading-none text-center text-indigo-700 px-6 py-3 border rounded-md border-indigo-700  hover:bg-gray-100 transform duration-300 ease-in-out" ]
                                    prop.text "Cancel"
                                ]
                                Html.button [
                                    prop.classes [ "text-sm font-medium leading-none text-white text-center  px-6 py-3 bg-indigo-700 rounded-md  hover:bg-indigo-600 transform duration-300 ease-in-out" ]
                                    prop.text "Search"
                                ]
                            ]
                        ]
                        Html.div [
                            prop.classes [ "space-y-4 mt-12 lg:hidden md:block block" ]
                            prop.children [
                                Html.button [
                                    prop.classes [ "text-sm font-medium leading-none text-center text-indigo-700 w-full px-6 py-3 border rounded-md border-indigo-700 hover:bg-gray-100 transform duration-300 ease-in-out" ]
                                    prop.text "Cancel"
                                ]
                                Html.button [
                                    prop.classes [ "text-sm font-medium leading-none text-white text-center w-full px-6 py-3 bg-indigo-700 rounded-md  hover:bg-indigo-600 transform duration-300 ease-in-out" ]
                                    prop.text "Search"
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]