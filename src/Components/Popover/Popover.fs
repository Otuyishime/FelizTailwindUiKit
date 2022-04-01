namespace App
namespace Components

module Popover =
    open Feliz
    open Browser.Types

    [<ReactComponent>]
    let WithDataAndActions() = 
        Html.div [
            prop.classes [ "flex md:flex-row flex-col items-start justify-center py-8" ]
            prop.children [
                Html.div [
                    prop.classes [ "mt-7" ]
                    prop.children [
                        Html.p [
                            prop.classes [ "text-gray-800 cursor-pointer text-xs -mt-10 ml-10 md:hidden" ]
                            prop.text "Popover"
                            prop.onClick (fun e -> ())
                        ]
                        Html.p [
                            prop.classes [ "text-gray-800 cursor-pointer mt-10 hidden md:block" ]
                            prop.text "Popover"
                            prop.onClick (fun e -> ())
                        ]
                    ]
                ]
                // Popover starts here
                Html.div [
                    prop.id "popover"
                    prop.classes [ "transition duration-150 ease-in-out ml-10 w-10/12 md:w-2/5" ]
                    prop.children [
                        Html.div [
                            prop.classes [ "w-full bg-white rounded shadow-2xl" ]
                            prop.children [
                                Html.div [
                                    prop.classes [ "relative bg-gray-200 rounded-t py-4 px-4 xl:px-8" ]
                                    prop.children [
                                        Svg.svg [
                                            svg.classes [ "hidden md:block absolute -ml-5 -mb-10 left-0 bottom-0" ]
                                            svg.width 30
                                            svg.height 30
                                            svg.viewBox(0, 0, 9, 16)
                                            Interop.svgAttribute "version" "1.1"
                                            svg.xmlns "http://www.w3.org/2000/svg"
                                            Interop.svgAttribute "xmlnsXlink" "http://www.w3.org/1999/xlink"
                                            svg.children [
                                                Svg.g [
                                                    svg.id "Page-1"
                                                    svg.stroke "none"
                                                    svg.strokeWidth 1
                                                    svg.fill "none"
                                                    Interop.svgAttribute "fillRule" "evenodd"
                                                    svg.children [
                                                        Svg.g [
                                                            svg.id "Tooltips-"
                                                            svg.transform.translate(-874, -1029)
                                                            svg.fill "#FFFFFF"
                                                            svg.children [
                                                                Svg.g [
                                                                    svg.id "Group-3-Copy-16"
                                                                    svg.transform.translate(850, 975)
                                                                    svg.children [
                                                                        Svg.g [
                                                                            svg.id "Group-2"
                                                                            svg.transform.translate(24, 0)
                                                                            svg.children [
                                                                                Svg.polygon [
                                                                                    svg.id "Triangle"
                                                                                    svg.transform [
                                                                                        transform.translate(4.5, 62.0)
                                                                                        transform.rotate -90
                                                                                        transform.translate(-4.5, -62.0)
                                                                                    ]
                                                                                    svg.points "4.5 57.5 12.5 66.5 -3.5 66.5"
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
                                        Html.p [
                                            prop.classes [ "text-sm text-gray-800 font-normal leading-normal tracking-normal opacity-50" ]
                                            prop.text "Search for people to invite"
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "w-full h-full px-4 xl:px-8 py-5" ]
                                    prop.children [
                                        Html.div [
                                            prop.classes [ "flex items-center justify-between" ]
                                            prop.children [
                                                Svg.svg [
                                                    svg.xmlns "http://www.w3.org/2000/svg"
                                                    svg.classes [ "icon icon-tabler icon-tabler-chevron-left" ]
                                                    svg.width 24
                                                    svg.height 24
                                                    svg.viewBox(0, 0, 24, 24)
                                                    svg.stroke "#2c3e50"
                                                    svg.strokeWidth 1.5
                                                    svg.fill "none"
                                                    Interop.svgAttribute "strokeLinecap" "round"
                                                    Interop.svgAttribute "strokeLinejoin" "round"
                                                    svg.children [
                                                        Svg.path [
                                                            svg.stroke "none"
                                                            svg.d "M0 0h24v24H0z"
                                                        ]
                                                        Svg.polyline [
                                                            svg.points "15 6 9 12 15 18"
                                                        ]
                                                    ]
                                                ]
                                                Html.div [
                                                    prop.classes [ "w-10 h-10 rounded-full shadow" ]
                                                    prop.children [
                                                        Html.img [
                                                            prop.classes [ "w-full h-full overflow-hidden object-cover object-center rounded-full" ]
                                                            prop.src "https://images.unsplash.com/photo-1570211776045-af3a51026f4a?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=500&q=80"
                                                            prop.alt "avatar"
                                                        ]
                                                    ]
                                                ]
                                                Html.div [
                                                    prop.classes [ "w-10 h-10 rounded-full shadow" ]
                                                    prop.children [
                                                        Html.img [
                                                            prop.classes [ "w-full h-full overflow-hidden object-cover object-center rounded-full" ]
                                                            prop.src "https://dh-ui.s3.amazonaws.com/assets/photo-1566753323558-f4e0952af115.jfif"
                                                            prop.alt "avatar"
                                                        ]
                                                    ]
                                                ]
                                                Html.div [
                                                    prop.classes [ "w-10 h-10 rounded-full shadow" ]
                                                    prop.children [
                                                        Html.img [
                                                            prop.classes [ "w-full h-full overflow-hidden object-cover object-center rounded-full" ]
                                                            prop.src "https://images.unsplash.com/photo-1586349425880-ab91652eae47?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=500&q=80"
                                                            prop.alt "avatar"
                                                        ]
                                                    ]
                                                ]
                                                Html.div [
                                                    prop.classes [ "w-10 h-10 rounded-full shadow" ]
                                                    prop.children [
                                                        Html.img [
                                                            prop.classes [ "w-full h-full overflow-hidden object-cover object-center rounded-full" ]
                                                            prop.src "https://images.unsplash.com/photo-1548958921-c5c0fe1b307d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=500&q=80"
                                                            prop.alt "avatar"
                                                        ]
                                                    ]
                                                ]
                                                Html.div [
                                                    prop.classes [ "w-10 h-10 rounded-full shadow" ]
                                                    prop.children [
                                                        Html.img [
                                                            prop.classes [ "w-full h-full overflow-hidden object-cover object-center rounded-full" ]
                                                            prop.src "https://images.unsplash.com/photo-1588544108061-3c44c505d45d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=500&q=80"
                                                            prop.alt "avatar"
                                                        ]
                                                    ]
                                                ]
                                                Svg.svg [
                                                    svg.xmlns "http://www.w3.org/2000/svg"
                                                    svg.classes [ "icon icon-tabler icon-tabler-chevron-right" ]
                                                    svg.width 24
                                                    svg.height 24
                                                    svg.viewBox(0, 0, 24, 24)
                                                    svg.stroke "#2c3e50"
                                                    svg.strokeWidth 1.5
                                                    svg.fill "none"
                                                    Interop.svgAttribute "strokeLinecap" "round"
                                                    Interop.svgAttribute "strokeLinejoin" "round"
                                                    svg.children [
                                                        Svg.path [
                                                            svg.stroke "none"
                                                            svg.d "M0 0h24v24H0z"
                                                        ]
                                                        Svg.polyline [
                                                            svg.points "9 6 15 12 9 18"
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.hr [
                                            prop.classes [ "my-5 border-t border-gray-200" ]
                                        ]
                                        Html.p [
                                            prop.classes [ "text-xs font-normal text-gray-800" ]
                                            prop.text "Known for"
                                        ]
                                        Html.div [
                                            prop.classes [ "flex items-center my-2" ]
                                            prop.children [
                                                Html.p [
                                                    prop.classes [ "text-xs text-indigo-700 font-normal" ]
                                                    prop.text "Sports"
                                                ]
                                                Html.p [
                                                    prop.classes [ "w-1 h-1 bg-gray-500 rounded-full mx-2" ]
                                                ]
                                                Html.p [
                                                    prop.classes [ "text-xs text-indigo-700 font-normal" ]
                                                    prop.text "Entertainment"
                                                ]
                                                Html.p [
                                                    prop.classes [ "w-1 h-1 bg-gray-500 rounded-full mx-2" ]
                                                ]
                                                Html.p [
                                                    prop.classes [ "text-xs text-indigo-700 font-normal" ]
                                                    prop.text "Hot Dogs"
                                                ]
                                            ]
                                        ]
                                        Html.p [
                                            prop.classes [ "text-gray-600 font-normal text-xs" ]
                                            prop.text "The responsibility to communicate that information rests on the shoulders of the marketing and sales teams. Typically, marketing has a predominant role at the beginning of a potential sale."
                                        ]
                                        Html.div [
                                            prop.children [
                                                Html.button [
                                                    prop.classes [ "mt-4 mr-2 sm:mr-3 font-normal focus:outline-none bg-indigo-700 transition duration-150 ease-in-out hover:bg-indigo-600 rounded text-white px-6 py-2 text-xs" ]
                                                    prop.text "Get Directions"
                                                ]
                                                Html.button [
                                                    prop.classes [ "mt-4 font-normal bg-gray-100 focus:outline-none transition duration-150 ease-in-out hover:bg-gray-300 rounded text-indigo-600 px-6 py-2 text-xs border border-gray-300" ]
                                                    prop.text "Schedule Alert"
                                                ]
                                            ]
                                        ]
                                        Html.hr [
                                            prop.classes [ "my-5 border-t border-gray-200" ]
                                        ]
                                        Html.label [
                                            prop.htmlFor "link"
                                            prop.classes [ "text-gray-600 text-xs font-normal" ]
                                            prop.text "Anyone with a link can view"
                                        ]
                                        Html.div [
                                            prop.classes [ "flex items-stretch mt-2" ]
                                            prop.children [
                                                Html.div [
                                                    prop.classes [ "relative w-full" ]
                                                    prop.children [
                                                        Html.div [
                                                            prop.classes [ "absolute text-gray-500 flex items-center px-2 border-r h-full" ]
                                                            prop.children [
                                                                Svg.svg [
                                                                    svg.xmlns "http://www.w3.org/2000/svg"
                                                                    svg.classes [ "icon icon-tabler icon-tabler-link" ]
                                                                    svg.width 18
                                                                    svg.height 18
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
                                                                        ]
                                                                        Svg.path [
                                                                            svg.d "M10 14a3.5 3.5 0 0 0 5 0l4 -4a3.5 3.5 0 0 0 -5 -5l-.5 .5"
                                                                        ]
                                                                        Svg.path [
                                                                            svg.d "M14 10a3.5 3.5 0 0 0 -5 0l-4 4a3.5 3.5 0 0 0 5 5l.5 -.5"
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.input [
                                                            prop.id "link"
                                                            prop.classes [ "pr-24 text-gray-600 bg-gray-100 focus:outline-none focus:border focus:border-indigo-700 font-normal w-full h-10 flex items-center pl-12 text-sm border-gray-300 rounded border" ]
                                                            prop.defaultValue "https://alphad.co/Q4XY3HWXN95"
                                                        ]
                                                        Html.button [
                                                            prop.classes [ "absolute right-0 top-0 transition duration-150 ease-in-out hover:bg-indigo-600 focus:outline-none bg-indigo-700 rounded-r text-white px-5 h-10 text-sm" ]
                                                            prop.text "Copy"
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
            ]
        ]

    [<ReactComponent>]
    let WithData() = 
        Html.div [
            prop.classes [ "flex md:flex-row flex-col items-start justify-center py-8" ]
            prop.children [
                Html.div [
                    prop.classes [ "mt-7" ]
                    prop.children [
                        Html.p [
                            prop.classes [ "text-gray-800 cursor-pointer text-xs -mt-10 ml-10 md:hidden" ]
                            prop.text "Popover"
                            prop.onClick (fun e -> ())
                        ]
                        Html.p [
                            prop.classes [ "text-gray-800 cursor-pointer mt-10 hidden md:block" ]
                            prop.text "Popover"
                            prop.onClick (fun e -> ())
                        ]
                    ]
                ]
                // Popover starts here
                Html.div [
                    prop.id "popover"
                    prop.classes [ "transition duration-150 ease-in-out ml-10 w-10/12 md:w-2/5" ]
                    prop.children [
                        Html.div [
                            prop.classes [ "w-full bg-white rounded shadow-2xl" ]
                            prop.children [
                                Html.div [
                                    prop.classes [ "relative bg-gray-200 rounded-t py-4 px-4 xl:px-8" ]
                                    prop.children [
                                        Svg.svg [
                                            svg.classes [ "hidden md:block absolute -ml-5 -mb-10 left-0 bottom-0" ]
                                            svg.width 30
                                            svg.height 30
                                            svg.viewBox(0, 0, 9, 16)
                                            Interop.svgAttribute "version" "1.1"
                                            svg.xmlns "http://www.w3.org/2000/svg"
                                            Interop.svgAttribute "xmlnsXlink" "http://www.w3.org/1999/xlink"
                                            svg.children [
                                                Svg.g [
                                                    svg.id "Page-1"
                                                    svg.stroke "none"
                                                    svg.strokeWidth 1
                                                    svg.fill "none"
                                                    Interop.svgAttribute "fillRule" "evenodd"
                                                    svg.children [
                                                        Svg.g [
                                                            svg.id "Tooltips-"
                                                            svg.transform.translate(-874, -1029)
                                                            svg.fill "#FFFFFF"
                                                            svg.children [
                                                                Svg.g [
                                                                    svg.id "Group-3-Copy-16"
                                                                    svg.transform.translate(850, 975)
                                                                    svg.children [
                                                                        Svg.g [
                                                                            svg.id "Group-2"
                                                                            svg.transform.translate(24, 0)
                                                                            svg.children [
                                                                                Svg.polygon [
                                                                                    svg.id "Triangle"
                                                                                    svg.transform [
                                                                                        transform.translate(4.5, 62.0)
                                                                                        transform.rotate -90
                                                                                        transform.translate(-4.5, -62.0)
                                                                                    ]
                                                                                    svg.points "4.5 57.5 12.5 66.5 -3.5 66.5"
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
                                        Svg.svg [
                                            svg.classes [ "absolute top-0 -mt-5 block md:hidden" ]
                                            svg.xmlns "http://www.w3.org/2000/svg"
                                            svg.width 26
                                            svg.height 26
                                            svg.viewBox(0, 0, 26, 23)
                                            svg.fill "none"
                                            svg.children [
                                                Svg.path [
                                                    svg.id "Polygon 2"
                                                    svg.d "M13 0L25.9904 22.5H0.00961876L13 0Z"
                                                    svg.fill "#e5e7eb"
                                                ]
                                            ]
                                        ]
                                        Html.p [
                                            prop.classes [ "text-sm text-gray-800 font-normal leading-normal tracking-normal" ]
                                            prop.text "435 South Side, Staples Centre"
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "w-full h-full px-4 xl:px-8 py-5" ]
                                    prop.children [
                                        Html.p [
                                            prop.classes [ "text-xs font-normal text-gray-800" ]
                                            prop.text "Known for"
                                        ]
                                        Html.div [
                                            prop.classes [ "flex items-center my-2" ]
                                            prop.children [
                                                Html.p [
                                                    prop.classes [ "text-xs text-indigo-700 font-normal" ]
                                                    prop.text "Sports"
                                                ]
                                                Html.p [
                                                    prop.classes [ "w-1 h-1 bg-gray-500 rounded-full mx-2" ]
                                                ]
                                                Html.p [
                                                    prop.classes [ "text-xs text-indigo-700 font-normal" ]
                                                    prop.text "Entertainment"
                                                ]
                                                Html.p [
                                                    prop.classes [ "w-1 h-1 bg-gray-500 rounded-full mx-2" ]
                                                ]
                                                Html.p [
                                                    prop.classes [ "text-xs text-indigo-700 font-normal" ]
                                                    prop.text "Hot Dogs"
                                                ]
                                            ]
                                        ]
                                        Html.p [
                                            prop.classes [ "text-gray-600 font-normal text-xs" ]
                                            prop.text "The responsibility to communicate that information rests on the shoulders of the marketing and sales teams. Typically, marketing has a predominant role at the beginning of a potential sale."
                                        ]
                                        Html.div [
                                            prop.children [
                                                Html.button [
                                                    prop.classes [ "mt-4 mr-2 sm:mr-3 font-normal focus:outline-none bg-indigo-700 transition duration-150 ease-in-out hover:bg-indigo-600 rounded text-white px-6 py-2 text-xs" ]
                                                    prop.text "Get Directions"
                                                ]
                                                Html.button [
                                                    prop.classes [ "mt-4 font-normal bg-gray-100 focus:outline-none transition duration-150 ease-in-out hover:bg-gray-300 rounded text-indigo-600 px-6 py-2 text-xs border border-gray-300" ]
                                                    prop.text "Schedule Alert"
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