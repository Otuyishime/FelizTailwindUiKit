namespace App
namespace Components

module Alert =
    open Feliz

    [<ReactComponent>]
    let WithTextActionButtons() = 
        let (flag, setFlag) = React.useState(true)

        Html.div [
            prop.classes [ "flex items-center justify-center px-4" ]
            prop.children [
                Html.div [
                    prop.id "alert"
                    prop.role.alert
                    prop.classes [ 
                        if flag 
                        then "transition duration-150 ease-in-out w-full lg:w-11/12 mx-auto bg-white dark:bg-gray-800 shadow rounded flex flex-col py-4 md:py-0 items-center md:flex-row justify-between" 
                        else "transition duration-150 ease-in-out w-full lg:w-11/12 mx-auto bg-white dark:bg-gray-800 shadow rounded flex flex-col py-4 md:py-0 items-center md:flex-row justify-between translate-hide" 
                    ]
                    prop.children [
                        Html.div [
                            prop.classes [ "flex flex-col items-center md:flex-row" ]
                            prop.children [
                                Html.div [
                                    prop.classes [ "p-3 pl-3.5 pr-3.5 bg-yellow-400 rounded md:rounded-tr-none md:rounded-br-none text-white" ]
                                    prop.children [
                                        Svg.svg [
                                            svg.xmlns "http://www.w3.org/2000/svg"
                                            svg.width 20
                                            svg.height 20
                                            svg.viewBox(0, 0, 24, 24)
                                            svg.fill "currentColor"
                                            svg.children [
                                                Svg.path [
                                                    svg.classes [ "heroicon-ui" ]
                                                    svg.stroke "none"
                                                    svg.d "M12 2a10 10 0 1 1 0 20 10 10 0 0 1 0-20zm0 2a8 8 0 1 0 0 16 8 8 0 0 0 0-16zm0 9a1 1 0 0 1-1-1V8a1 1 0 0 1 2 0v4a1 1 0 0 1-1 1zm0 4a1 1 0 1 1 0-2 1 1 0 0 1 0 2z"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.p [
                                    prop.classes [ "ml-2 mr-2 text-base font-bold text-gray-800 dark:text-gray-100 mt-2 md:my-0" ]
                                    prop.text "Warning"
                                ]
                                Html.div [
                                    prop.classes [ "h-1 w-1 bg-gray-300 dark:bg-gray-700 rounded-full mr-2 hidden xl:block" ]
                                ]
                                Html.p [
                                    prop.classes [ "text-sm lg:text-base dark:text-gray-400 text-gray-600 lg:pt-1 xl:pt-0 sm:mb-0 mb-2 text-center sm:text-left" ]
                                    prop.text "Hurricane warning in this area. Please check local media and authorities-NWS."
                                ]
                            ]
                        ]
                        Html.div [
                            prop.classes [ "flex xl:items-center lg:items-center sm:justify-end justify-center pr-4" ]
                            prop.children [
                                Html.button [
                                    prop.classes [ "focus:outline-none focus:text-indigo-400 hover:text-indigo-400 text-sm mr-4 font-bold cursor-pointer text-indigo-700 dark:text-indigo-600" ]
                                    prop.text "Details"
                                ]
                                Html.button [
                                    prop.classes [ "focus:outline-none focus:text-gray-400 hover:text-gray-400 text-sm cursor-pointer text-gray-600 dark:text-gray-400" ]
                                    prop.text "Dismiss"
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]

    [<ReactComponent>]
    let WithActionButton() =
        let (flag, setFlag) = React.useState(true)

        Html.div [
            prop.classes [ "flex items-center justify-center px-4" ]
            prop.children [
                Html.div [
                    prop.id "alert"
                    prop.role.alert
                    prop.classes [ 
                        if flag 
                        then "transition duration-150 ease-in-out w-full lg:w-11/12 mx-auto bg-white dark:bg-gray-800 shadow rounded flex flex-col py-4 md:py-0 items-center md:flex-row justify-between" 
                        else "transition duration-150 ease-in-out w-full lg:w-11/12 mx-auto bg-white dark:bg-gray-800 shadow rounded flex flex-col py-4 md:py-0 items-center md:flex-row justify-between translate-hide" 
                    ]
                    prop.children [
                        Html.div [
                            prop.classes [ "flex flex-col items-center md:flex-row" ]
                            prop.children [
                                Html.div [
                                    prop.classes [ "mr-3 p-3.5 bg-yellow-400 rounded md:rounded-tr-none md:rounded-br-none text-white" ]
                                    prop.children [
                                        Svg.svg [
                                            svg.xmlns "http://www.w3.org/2000/svg"
                                            svg.width 20
                                            svg.height 20
                                            svg.viewBox(0, 0, 24, 24)
                                            svg.fill "currentColor"
                                            svg.children [
                                                Svg.path [
                                                    svg.classes [ "heroicon-ui" ]
                                                    svg.stroke "none"
                                                    svg.d "M12 2a10 10 0 1 1 0 20 10 10 0 0 1 0-20zm0 2a8 8 0 1 0 0 16 8 8 0 0 0 0-16zm0 9a1 1 0 0 1-1-1V8a1 1 0 0 1 2 0v4a1 1 0 0 1-1 1zm0 4a1 1 0 1 1 0-2 1 1 0 0 1 0 2z"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.p [
                                    prop.classes [ "mr-2 text-sm font-bold text-gray-800 dark:text-gray-100 mt-2 md:my-0" ]
                                    prop.text "Warning"
                                ]
                                Html.div [
                                    prop.classes [ "h-1 w-1 bg-gray-300 dark:bg-gray-700 rounded-full mr-2 hidden xl:block" ]
                                ]
                                Html.p [
                                    prop.classes [ "text-sm lg:text-sm dark:text-gray-400 text-gray-600 lg:pt-1 xl:pt-0 sm:mb-0 mb-2 text-center sm:text-left" ]
                                    prop.text "Hurricane warning in this area. Please check local media and authorities-NWS"
                                ]
                            ]
                        ]
                        Html.div [
                            prop.classes [ "flex xl:items-center lg:items-center sm:justify-end justify-center pr-4" ]
                            prop.children [
                                Html.button [
                                    prop.classes [ "focus:outline-none mr-8 bg-indigo-700 transition duration-150 ease-in-out hover:bg-indigo-600 rounded text-white px-8 py-2 text-xs" ]
                                    prop.text "View"
                                ]
                                Html.div [
                                    prop.onClick (fun e -> setFlag(false))
                                    prop.classes [ "cursor-pointer text-gray-400" ]
                                    prop.children [
                                        Svg.svg [
                                            svg.xmlns "http://www.w3.org/2000/svg"
                                            svg.classes [ "feather feather-x" ]
                                            svg.width 18
                                            svg.height 18
                                            svg.viewBox(0, 0, 24, 24)
                                            svg.fill "none"
                                            svg.stroke "currentColor"
                                            Interop.svgAttribute "strokeLinecap" "round"
                                            Interop.svgAttribute "strokeLinejoin" "round"
                                            svg.children [
                                                Svg.line [
                                                    svg.x1 18
                                                    svg.y1 6
                                                    svg.x2 6
                                                    svg.y2 18
                                                ]
                                                Svg.line [
                                                    svg.x1 6
                                                    svg.y1 6
                                                    svg.x2 18
                                                    svg.y2 18
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]