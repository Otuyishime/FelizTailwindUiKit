namespace App
namespace Components

module ProgressBar =
    open Feliz
    open Fable.AST.Babel

    [<ReactComponent>]
    let Small() = 
        Html.button [
            prop.classes [ 
                "mx-2" 
                "my-2" 
                "bg-white" 
                "transition" 
                "duration-150" 
                "ease-in-out" 
                "focus:outline-none" 
                "rounded" 
                "text-gray-800" 
                "border" 
                "border-gray-300" 
                "px-4" 
                "py-1.5" 
                "text-xs"
                "shadow"
                "hover:bg-gray-200"
            ]
            prop.text "Small Button"
            prop.tabIndex 0
        ]

    
    [<ReactComponent>]
    let ThinWithSteps() =
        Html.div [
            prop.classes [ "w-11/12 lg:w-2/6 mx-auto" ]
            prop.children [
                Html.div [
                    prop.classes [ "bg-gray-200 h-1 flex items-center justify-between" ]
                    prop.children [
                        Html.div [
                            prop.classes [ "w-1/3 bg-indigo-700 h-1 flex items-center" ]
                            prop.children [
                                Html.div [
                                    prop.classes [ "bg-indigo-700 h-6 w-6 rounded-full shadow flex items-center justify-center" ]
                                    prop.children [
                                        Svg.svg [
                                            svg.xmlns "http://www.w3.org/2000/svg"
                                            svg.classes [ "icon icon-tabler icon-tabler-check" ]
                                            svg.width 18
                                            svg.height 18
                                            svg.viewBox(0, 0, 24, 24)
                                            svg.stroke "#FFFFFF"
                                            svg.strokeWidth 1.5
                                            svg.fill "none"
                                            Interop.svgAttribute "strokeLinecap" "round"
                                            Interop.svgAttribute "strokeLinejoin" "round"
                                            svg.children [
                                                Svg.path [
                                                    svg.stroke "none"
                                                    svg.d "M0 0h24v24H0z"
                                                ]
                                                Svg.path [
                                                    svg.d "M5 12l5 5l10 -10"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.classes [ "w-1/3 flex justify-between bg-indigo-700 h-1 items-center relative" ]
                            prop.children [
                                Html.div [
                                    prop.classes [ "absolute right-0 -mr-2" ]
                                    prop.children [
                                        Html.div [
                                            prop.classes [ "relative bg-white shadow-lg px-2 py-1 rounded mt-16 -mr-12" ]
                                            prop.children [
                                                Svg.svg [
                                                    svg.xmlns "http://www.w3.org/2000/svg"
                                                    svg.classes [ "absolute top-0 -mt-1 w-full right-0 left-0" ]
                                                    svg.width 16
                                                    svg.height 16
                                                    svg.viewBox(0, 0, 16, 8)
                                                    Interop.svgAttribute "version" "1.1"
                                                    svg.children [
                                                        Svg.g [
                                                            svg.id "Page-1"
                                                            svg.stroke "none"
                                                            svg.strokeWidth 1
                                                            svg.fill "none"
                                                            Interop.svgAttribute "fillRule" "evenodd"
                                                            svg.children [
                                                                Svg.g [
                                                                    svg.id "Progress-Bars"
                                                                    svg.transform [
                                                                        transform.translate(-322.0, -198.0)
                                                                    ]
                                                                    svg.fill "#FFFFFF"
                                                                    svg.children [
                                                                        Svg.g [
                                                                            svg.id "Group-4"
                                                                            svg.transform [
                                                                                transform.translate(310.0, 198.0)
                                                                            ]
                                                                            svg.children [
                                                                                Svg.polygon [
                                                                                    svg.id "Triangle"
                                                                                    svg.transform [
                                                                                        transform.translate(4.5, 62.0)
                                                                                        transform.rotate -90
                                                                                        transform.translate(-4.5, -62.0)
                                                                                    ]
                                                                                    svg.points "20 0 28 8 12 8"
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                                Html.p [
                                                    prop.classes [ "text-indigo-700 text-sm font-normal" ]
                                                    prop.text "Step 3: Analyzing"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "bg-indigo-700 h-6 w-6 rounded-full shadow flex items-center justify-center -ml-2" ]
                                    prop.children [
                                        Svg.svg [
                                            svg.xmlns "http://www.w3.org/2000/svg"
                                            svg.classes [ "icon icon-tabler icon-tabler-check" ]
                                            svg.width 18
                                            svg.height 18
                                            svg.viewBox(0, 0, 24, 24)
                                            svg.stroke "#FFFFFF"
                                            svg.strokeWidth 1.5
                                            svg.fill "none"
                                            Interop.svgAttribute "strokeLinecap" "round"
                                            Interop.svgAttribute "strokeLinejoin" "round"
                                            svg.children [
                                                Svg.path [
                                                    svg.stroke "none"
                                                    svg.d "M0 0h24v24H0z"
                                                ]
                                                Svg.path [
                                                    svg.d "M5 12l5 5l10 -10"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "bg-white h-6 w-6 rounded-full shadow flex items-center justify-center -mr-3 relative" ]
                                    prop.children [
                                        Html.div [
                                            prop.classes [ "h-3 w-3 bg-indigo-700 rounded-full" ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.classes [ "w-1/3 flex justify-end" ]
                            prop.children [
                                Html.div [
                                    prop.classes [ "bg-white h-6 w-6 rounded-full shadow" ]
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]