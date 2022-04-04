namespace App
namespace Components

module Badge =
    open Feliz

    [<ReactComponent>]
    let WithBullet() = 
        Html.div [
            prop.classes [ "px-6 flex items-center sm:flex-row justify-between flex-wrap" ]
            prop.children [
                Html.div [
                    prop.classes [ "border border-gray-300 dark:border-gray-700 h-8 w-24 mb-4 md:mb-0 rounded-md flex items-center justify-center" ]
                    prop.children [
                        Html.div [
                            prop.classes [ "flex items-center" ]
                            prop.children [
                                Html.div [
                                    prop.classes [ "h-1 w-1 rounded-full bg-indigo-700 mr-1" ]
                                ]
                                Html.span [
                                    prop.classes [ "text-xs text-gray-800 dark:text-gray-100 font-normal" ]
                                    prop.text "Badge"
                                ]
                            ]
                        ]
                    ]
                ]

                // Second badge
                Html.div [
                    prop.classes [ "bg-gray-200 dark:bg-gray-800 h-8 w-24 mb-4 md:mb-0 rounded-md flex items-center justify-center" ]
                    prop.children [
                        Html.div [
                            prop.classes [ "flex items-center" ]
                            prop.children [
                                Html.div [
                                    prop.classes [ "h-1 w-1 rounded-full bg-indigo-700 mr-1" ]
                                ]
                                Html.span [
                                    prop.classes [ "text-xs text-gray-800 dark:text-gray-100 font-normal" ]
                                    prop.text "Badge"
                                ]
                            ]
                        ]
                    ]
                ]

                // Third
                Html.div [
                    prop.classes [ "bg-indigo-200 h-8 w-24 mb-4 md:mb-0 rounded-md flex items-center justify-center" ]
                    prop.children [
                        Html.div [
                            prop.classes [ "flex items-center" ]
                            prop.children [
                                Html.div [
                                    prop.classes [ "h-1 w-1 rounded-full bg-indigo-700 mr-1" ]
                                ]
                                Html.span [
                                    prop.classes [ "text-xs text-gray-800 dark:text-gray-100 font-normal" ]
                                    prop.text "Badge"
                                ]
                            ]
                        ]
                    ]
                ]

                // Fourth
                Html.div [
                    prop.classes [ "bg-yellow-200 h-8 w-24 mb-4 md:mb-0 rounded-md flex items-center justify-center" ]
                    prop.children [
                        Html.div [
                            prop.classes [ "flex items-center" ]
                            prop.children [
                                Html.div [
                                    prop.classes [ "h-1 w-1 rounded-full bg-indigo-700 mr-1" ]
                                ]
                                Html.span [
                                    prop.classes [ "text-xs text-gray-800 dark:text-gray-100 font-normal" ]
                                    prop.text "Badge"
                                ]
                            ]
                        ]
                    ]
                ]

                // Fith
                Html.div [
                    prop.classes [ "bg-red-200 h-8 w-24 mb-4 md:mb-0 rounded-md flex items-center justify-center" ]
                    prop.children [
                        Html.div [
                            prop.classes [ "flex items-center" ]
                            prop.children [
                                Html.div [
                                    prop.classes [ "h-1 w-1 rounded-full bg-indigo-700 mr-1" ]
                                ]
                                Html.span [
                                    prop.classes [ "text-xs text-gray-800 dark:text-gray-100 font-normal" ]
                                    prop.text "Badge"
                                ]
                            ]
                        ]
                    ]
                ]

                // Sixth
                Html.div [
                    prop.classes [ "bg-green-200 h-8 w-24 mb-4 md:mb-0 rounded-md flex items-center justify-center" ]
                    prop.children [
                        Html.div [
                            prop.classes [ "flex items-center" ]
                            prop.children [
                                Html.div [
                                    prop.classes [ "h-1 w-1 rounded-full bg-indigo-700 mr-1" ]
                                ]
                                Html.span [
                                    prop.classes [ "text-xs text-gray-800 dark:text-gray-100 font-normal" ]
                                    prop.text "Badge"
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]

    [<ReactComponent>]
    let WithCloseButton() =
        Html.div [
            prop.classes [ "px-6 flex sm:flex-row flex-wrap items-center" ]
            prop.children [
                Html.div [
                    prop.classes [ "bg-indigo-200 h-6 w-20 mb-4 md:mb-0 rounded-md flex items-center justify-center mr-8" ]
                    prop.children [
                        Html.div [
                            prop.classes [ "flex items-center justify-around h-full w-full" ]
                            prop.children [
                                Html.span [
                                    prop.classes [ "text-xs text-indigo-700 font-normal" ]
                                    prop.text "Badge"
                                ]
                                Html.div [
                                    Svg.svg [
                                        svg.xmlns "http://www.w3.org/2000/svg"
                                        svg.classes [ "icon icon-tabler icon-tabler-x" ]
                                        svg.width 12
                                        svg.height 12
                                        svg.viewBox(0, 0, 24, 24)
                                        svg.stroke "#667EEA"
                                        svg.strokeWidth 2
                                        svg.fill "none"
                                        Interop.svgAttribute "strokeLinecap" "round"
                                        Interop.svgAttribute "strokeLinejoin" "round"
                                        svg.children [
                                            Svg.path [
                                                svg.stroke "none"
                                                svg.d "M0 0h24v24H0z"
                                            ]
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

                // Large
                Html.div [
                    prop.classes [ "bg-indigo-200 h-8 w-24 mb-4 md:mb-0 rounded-md flex items-center justify-center" ]
                    prop.children [
                        Html.div [
                            prop.classes [ "flex items-center justify-around h-full w-full" ]
                            prop.children [
                                Html.span [
                                    prop.classes [ "text-xs text-indigo-700 font-normal" ]
                                    prop.text "Badge"
                                ]
                                Html.div [
                                    Svg.svg [
                                        svg.xmlns "http://www.w3.org/2000/svg"
                                        svg.classes [ "icon icon-tabler icon-tabler-x" ]
                                        svg.width 12
                                        svg.height 12
                                        svg.viewBox(0, 0, 24, 24)
                                        svg.stroke "#667EEA"
                                        svg.strokeWidth 2
                                        svg.fill "none"
                                        Interop.svgAttribute "strokeLinecap" "round"
                                        Interop.svgAttribute "strokeLinejoin" "round"
                                        svg.children [
                                            Svg.path [
                                                svg.stroke "none"
                                                svg.d "M0 0h24v24H0z"
                                            ]
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