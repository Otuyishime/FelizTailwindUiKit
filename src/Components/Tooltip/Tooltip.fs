namespace App
namespace Components

module Tooltip =
    open Feliz

    [<ReactComponent>]
    let Simple() = 
        Html.div [
            prop.classes [ "py-12" ]
            prop.children [
                Html.div [
                    prop.classes [ "mx-auto container max-w-[228px] px-4 py-4 bg-gray-200 rounded relative" ]
                    prop.children [
                        Html.p [
                            prop.classes [ "text-sm font-semibold leading-none text-gray-800" ]
                            prop.text "Tooltip Title"
                        ]
                        Html.p [
                            prop.classes [ "text-xs leading-none text-gray-600 pt-2 pb-2" ]
                            prop.text "Tooltip Description will come here!"
                        ]
                        Svg.svg [
                            svg.xmlns "http://www.w3.org/2000/svg"
                            svg.classes [ "absolute z-10 bottom-[-10px]" ]
                            svg.width 16
                            svg.height 10
                            svg.viewBox(0, 0, 16, 10)
                            svg.fill "none"
                            svg.children [
                                Svg.path [
                                    svg.d "M8 10L0 0L16 1.41326e-06L8 10Z"
                                    svg.fill "#e5e7eb"
                                ]
                            ]
                        ]
                        Svg.svg [
                            svg.xmlns "http://www.w3.org/2000/svg"
                            svg.classes [ "absolute bottom-[-30px] z-10 cursor-pointer" ]
                            svg.width 16
                            svg.height 16
                            svg.viewBox(0, 0, 16, 16)
                            svg.fill "none"
                            svg.children [
                                Svg.path [
                                    svg.d "M7.75 2C4.57469 2 2 4.57469 2 7.75C2 10.9253 4.57469 13.5 7.75 13.5C10.9253 13.5 13.5 10.9253 13.5 7.75C13.5 4.57469 10.9253 2 7.75 2Z"
                                    svg.stroke "#1F2937"
                                    Interop.svgAttribute "strokeMiterlimit" 10
                                ]
                                Svg.path [
                                    svg.d "M6.875 6.875H7.875V10.5"
                                    svg.stroke "#1F2937"
                                    Interop.svgAttribute "strokeLinecap" "round"
                                    Interop.svgAttribute "strokeLinejoin" "round"
                                ]
                                Svg.path [
                                    svg.d "M6.5 10.625H9.25"
                                    svg.stroke "#1F2937"
                                    Interop.svgAttribute "strokeMiterlimit" 10
                                    Interop.svgAttribute "strokeLinecap" "round"
                                ]
                                Svg.path [
                                    svg.d "M7.75 4.0625C7.5893 4.0625 7.43222 4.11015 7.2986 4.19943C7.16499 4.28871 7.06084 4.41561 6.99935 4.56407C6.93785 4.71254 6.92176 4.8759 6.95311 5.03351C6.98446 5.19112 7.06185 5.3359 7.17548 5.44953C7.28911 5.56316 7.43388 5.64054 7.59149 5.67189C7.7491 5.70324 7.91247 5.68715 8.06093 5.62566C8.2094 5.56416 8.3363 5.46002 8.42557 5.3264C8.51485 5.19279 8.5625 5.0357 8.5625 4.875C8.5625 4.65951 8.4769 4.45285 8.32453 4.30048C8.17215 4.1481 7.96549 4.0625 7.75 4.0625Z"
                                    svg.fill "#1F2937"
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]

    [<ReactComponent>]
    let WithButton() = 
        Html.div [
            prop.classes [ "py-12" ]
            prop.children [
                Html.div [
                    prop.classes [ "mx-auto container max-w-[228px] px-4 py-4 bg-green-200 rounded relative" ]
                    prop.children [
                        Html.div [
                            prop.classes [ "flex gap-2" ]
                            prop.children [
                                Svg.svg [
                                    svg.xmlns "http://www.w3.org/2000/svg"
                                    svg.classes [ "w-4 h-4" ]
                                    svg.width 16
                                    svg.height 16
                                    svg.viewBox(0, 0, 16, 16)
                                    svg.fill "none"
                                    svg.children [
                                        Svg.path [
                                            svg.d "M7.75 2C4.57469 2 2 4.57469 2 7.75C2 10.9253 4.57469 13.5 7.75 13.5C10.9253 13.5 13.5 10.9253 13.5 7.75C13.5 4.57469 10.9253 2 7.75 2Z"
                                            svg.stroke "#1F2937"
                                            Interop.svgAttribute "strokeMiterlimit" 10
                                        ]
                                        Svg.path [
                                            svg.d "M6.875 6.875H7.875V10.5"
                                            svg.stroke "#1F2937"
                                            Interop.svgAttribute "strokeLinecap" "round"
                                            Interop.svgAttribute "strokeLinejoin" "round"
                                        ]
                                        Svg.path [
                                            svg.d "M6.5 10.625H9.25"
                                            svg.stroke "#1F2937"
                                            Interop.svgAttribute "strokeMiterlimit" 10
                                            Interop.svgAttribute "strokeLinecap" "round"
                                        ]
                                        Svg.path [
                                            svg.d "M7.75 4.0625C7.5893 4.0625 7.43222 4.11015 7.2986 4.19943C7.16499 4.28871 7.06084 4.41561 6.99935 4.56407C6.93785 4.71254 6.92176 4.8759 6.95311 5.03351C6.98446 5.19112 7.06185 5.3359 7.17548 5.44953C7.28911 5.56316 7.43388 5.64054 7.59149 5.67189C7.7491 5.70324 7.91247 5.68715 8.06093 5.62566C8.2094 5.56416 8.3363 5.46002 8.42557 5.3264C8.51485 5.19279 8.5625 5.0357 8.5625 4.875C8.5625 4.65951 8.4769 4.45285 8.32453 4.30048C8.17215 4.1481 7.96549 4.0625 7.75 4.0625Z"
                                            svg.fill "#1F2937"
                                        ]
                                    ]
                                ]
                                Html.p [
                                    prop.classes [ "text-sm font-semibold leading-none text-gray-800" ]
                                    prop.text "Tooltip Title"
                                ]
                            ]
                        ]
                        Html.p [
                            prop.classes [ "text-xs leading-none text-gray-600 pt-2 pb-2" ]
                            prop.text "Tooltip Description will come here!"
                        ]
                        Html.div [
                            prop.classes [ "pt-3" ]
                            prop.children [
                                Html.button [
                                    prop.classes [ "text-xs font-medium leading-3 text-center text-white px-3 py-2 bg-indigo-700 rounded-md w-full hover:bg-indigo-600 transform duration-300 ease-in-out" ]
                                    prop.text "Got It"
                                ]
                            ]
                        ]
                        Svg.svg [
                            svg.xmlns "http://www.w3.org/2000/svg"
                            svg.classes [ "absolute z-10 bottom-[-10px]" ]
                            svg.width 16
                            svg.height 10
                            svg.viewBox(0, 0, 16, 10)
                            svg.fill "none"
                            svg.children [
                                Svg.path [
                                    svg.d "M8 10L0 0L16 1.41326e-06L8 10Z"
                                    svg.fill "#A7F3D0"
                                ]
                            ]
                        ]
                        Svg.svg [
                            svg.xmlns "http://www.w3.org/2000/svg"
                            svg.classes [ "absolute bottom-[-30px] z-10 cursor-pointer" ]
                            svg.width 16
                            svg.height 16
                            svg.viewBox(0, 0, 16, 16)
                            svg.fill "none"
                            svg.children [
                                Svg.path [
                                    svg.d "M7.75 2C4.57469 2 2 4.57469 2 7.75C2 10.9253 4.57469 13.5 7.75 13.5C10.9253 13.5 13.5 10.9253 13.5 7.75C13.5 4.57469 10.9253 2 7.75 2Z"
                                    svg.stroke "#1F2937"
                                    Interop.svgAttribute "strokeMiterlimit" 10
                                ]
                                Svg.path [
                                    svg.d "M6.875 6.875H7.875V10.5"
                                    svg.stroke "#1F2937"
                                    Interop.svgAttribute "strokeLinecap" "round"
                                    Interop.svgAttribute "strokeLinejoin" "round"
                                ]
                                Svg.path [
                                    svg.d "M6.5 10.625H9.25"
                                    svg.stroke "#1F2937"
                                    Interop.svgAttribute "strokeMiterlimit" 10
                                    Interop.svgAttribute "strokeLinecap" "round"
                                ]
                                Svg.path [
                                    svg.d "M7.75 4.0625C7.5893 4.0625 7.43222 4.11015 7.2986 4.19943C7.16499 4.28871 7.06084 4.41561 6.99935 4.56407C6.93785 4.71254 6.92176 4.8759 6.95311 5.03351C6.98446 5.19112 7.06185 5.3359 7.17548 5.44953C7.28911 5.56316 7.43388 5.64054 7.59149 5.67189C7.7491 5.70324 7.91247 5.68715 8.06093 5.62566C8.2094 5.56416 8.3363 5.46002 8.42557 5.3264C8.51485 5.19279 8.5625 5.0357 8.5625 4.875C8.5625 4.65951 8.4769 4.45285 8.32453 4.30048C8.17215 4.1481 7.96549 4.0625 7.75 4.0625Z"
                                    svg.fill "#1F2937"
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]

    [<ReactComponent>]
    let WithDoubleCta() = 
        Html.div [
            prop.classes [ "py-12" ]
            prop.children [
                Html.div [
                    prop.classes [ "mx-auto container max-w-[228px] px-4 py-4 bg-gray-200 rounded relative" ]
                    prop.children [
                        Html.p [
                            prop.classes [ "text-sm font-semibold leading-none text-gray-800" ]
                            prop.text "Tooltip Title"
                        ]
                        Html.p [
                            prop.classes [ "text-xs leading-none text-gray-600 pt-2 pb-2" ]
                            prop.text "Tooltip Description will come here!"
                        ]
                        Html.div [
                            prop.classes [ "pt-3 flex gap-2" ]
                            prop.children [
                                // Ctas
                                Html.button [
                                    prop.classes [ "text-xs font-medium leading-3 text-center text-indigo-700 px-3 py-2 border rounded-md border-indigo-700 w-full hover:bg-gray-100 transform duration-300 ease-in-out" ]
                                    prop.text "Learn More"
                                ]
                                Html.button [
                                    prop.classes [ "text-xs font-medium leading-3 text-center text-white px-3 py-2 bg-indigo-700 rounded-md w-full hover:bg-indigo-600 transform duration-300 ease-in-out" ]
                                    prop.text "Got it"
                                ]
                            ]
                        ]
                        Svg.svg [
                            svg.xmlns "http://www.w3.org/2000/svg"
                            svg.classes [ "absolute z-10 bottom-[-10px]" ]
                            svg.width 16
                            svg.height 10
                            svg.viewBox(0, 0, 16, 10)
                            svg.fill "none"
                            svg.children [
                                Svg.path [
                                    svg.d "M8 10L0 0L16 1.41326e-06L8 10Z"
                                    svg.fill "#e5e7eb"
                                ]
                            ]
                        ]
                        Svg.svg [
                            svg.xmlns "http://www.w3.org/2000/svg"
                            svg.classes [ "absolute bottom-[-30px] z-10 cursor-pointer" ]
                            svg.width 16
                            svg.height 16
                            svg.viewBox(0, 0, 16, 16)
                            svg.fill "none"
                            svg.children [
                                Svg.path [
                                    svg.d "M7.75 2C4.57469 2 2 4.57469 2 7.75C2 10.9253 4.57469 13.5 7.75 13.5C10.9253 13.5 13.5 10.9253 13.5 7.75C13.5 4.57469 10.9253 2 7.75 2Z"
                                    svg.stroke "#1F2937"
                                    Interop.svgAttribute "strokeMiterlimit" 10
                                ]
                                Svg.path [
                                    svg.d "M6.875 6.875H7.875V10.5"
                                    svg.stroke "#1F2937"
                                    Interop.svgAttribute "strokeLinecap" "round"
                                    Interop.svgAttribute "strokeLinejoin" "round"
                                ]
                                Svg.path [
                                    svg.d "M6.5 10.625H9.25"
                                    svg.stroke "#1F2937"
                                    Interop.svgAttribute "strokeMiterlimit" 10
                                    Interop.svgAttribute "strokeLinecap" "round"
                                ]
                                Svg.path [
                                    svg.d "M7.75 4.0625C7.5893 4.0625 7.43222 4.11015 7.2986 4.19943C7.16499 4.28871 7.06084 4.41561 6.99935 4.56407C6.93785 4.71254 6.92176 4.8759 6.95311 5.03351C6.98446 5.19112 7.06185 5.3359 7.17548 5.44953C7.28911 5.56316 7.43388 5.64054 7.59149 5.67189C7.7491 5.70324 7.91247 5.68715 8.06093 5.62566C8.2094 5.56416 8.3363 5.46002 8.42557 5.3264C8.51485 5.19279 8.5625 5.0357 8.5625 4.875C8.5625 4.65951 8.4769 4.45285 8.32453 4.30048C8.17215 4.1481 7.96549 4.0625 7.75 4.0625Z"
                                    svg.fill "#1F2937"
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]

    [<ReactComponent>]
    let WithIcon() = 
        Html.div [
            prop.classes [ "py-12" ]
            prop.children [
                Html.div [
                    prop.classes [ "mx-auto container max-w-[228px] px-4 py-4 bg-green-200 rounded relative" ]
                    prop.children [
                        Html.div [
                            prop.classes [ "flex gap-2" ]
                            prop.children [
                                Svg.svg [
                                    svg.xmlns "http://www.w3.org/2000/svg"
                                    svg.classes [ "w-4 h-4" ]
                                    svg.width 16
                                    svg.height 16
                                    svg.viewBox(0, 0, 16, 16)
                                    svg.fill "none"
                                    svg.children [
                                        Svg.path [
                                            svg.d "M7.75 2C4.57469 2 2 4.57469 2 7.75C2 10.9253 4.57469 13.5 7.75 13.5C10.9253 13.5 13.5 10.9253 13.5 7.75C13.5 4.57469 10.9253 2 7.75 2Z"
                                            svg.stroke "#1F2937"
                                            Interop.svgAttribute "strokeMiterlimit" 10
                                        ]
                                        Svg.path [
                                            svg.d "M6.875 6.875H7.875V10.5"
                                            svg.stroke "#1F2937"
                                            Interop.svgAttribute "strokeLinecap" "round"
                                            Interop.svgAttribute "strokeLinejoin" "round"
                                        ]
                                        Svg.path [
                                            svg.d "M6.5 10.625H9.25"
                                            svg.stroke "#1F2937"
                                            Interop.svgAttribute "strokeMiterlimit" 10
                                            Interop.svgAttribute "strokeLinecap" "round"
                                        ]
                                        Svg.path [
                                            svg.d "M7.75 4.0625C7.5893 4.0625 7.43222 4.11015 7.2986 4.19943C7.16499 4.28871 7.06084 4.41561 6.99935 4.56407C6.93785 4.71254 6.92176 4.8759 6.95311 5.03351C6.98446 5.19112 7.06185 5.3359 7.17548 5.44953C7.28911 5.56316 7.43388 5.64054 7.59149 5.67189C7.7491 5.70324 7.91247 5.68715 8.06093 5.62566C8.2094 5.56416 8.3363 5.46002 8.42557 5.3264C8.51485 5.19279 8.5625 5.0357 8.5625 4.875C8.5625 4.65951 8.4769 4.45285 8.32453 4.30048C8.17215 4.1481 7.96549 4.0625 7.75 4.0625Z"
                                            svg.fill "#1F2937"
                                        ]
                                    ]
                                ]
                                Html.p [
                                    prop.classes [ "text-sm font-semibold leading-none text-gray-800" ]
                                    prop.text "Tooltip Title"
                                ]
                            ]
                        ]
                        Html.p [
                            prop.classes [ "text-xs leading-none text-gray-600 pt-2 pb-2" ]
                            prop.text "Tooltip Description will come here!"
                        ]
                        Svg.svg [
                            svg.xmlns "http://www.w3.org/2000/svg"
                            svg.classes [ "absolute z-10 bottom-[-10px]" ]
                            svg.width 16
                            svg.height 10
                            svg.viewBox(0, 0, 16, 10)
                            svg.fill "none"
                            svg.children [
                                Svg.path [
                                    svg.d "M8 10L0 0L16 1.41326e-06L8 10Z"
                                    svg.fill "#A7F3D0"
                                ]
                            ]
                        ]
                        Svg.svg [
                            svg.xmlns "http://www.w3.org/2000/svg"
                            svg.classes [ "absolute bottom-[-30px] z-10 cursor-pointer" ]
                            svg.width 16
                            svg.height 16
                            svg.viewBox(0, 0, 16, 16)
                            svg.fill "none"
                            svg.children [
                                Svg.path [
                                    svg.d "M7.75 2C4.57469 2 2 4.57469 2 7.75C2 10.9253 4.57469 13.5 7.75 13.5C10.9253 13.5 13.5 10.9253 13.5 7.75C13.5 4.57469 10.9253 2 7.75 2Z"
                                    svg.stroke "#1F2937"
                                    Interop.svgAttribute "strokeMiterlimit" 10
                                ]
                                Svg.path [
                                    svg.d "M6.875 6.875H7.875V10.5"
                                    svg.stroke "#1F2937"
                                    Interop.svgAttribute "strokeLinecap" "round"
                                    Interop.svgAttribute "strokeLinejoin" "round"
                                ]
                                Svg.path [
                                    svg.d "M6.5 10.625H9.25"
                                    svg.stroke "#1F2937"
                                    Interop.svgAttribute "strokeMiterlimit" 10
                                    Interop.svgAttribute "strokeLinecap" "round"
                                ]
                                Svg.path [
                                    svg.d "M7.75 4.0625C7.5893 4.0625 7.43222 4.11015 7.2986 4.19943C7.16499 4.28871 7.06084 4.41561 6.99935 4.56407C6.93785 4.71254 6.92176 4.8759 6.95311 5.03351C6.98446 5.19112 7.06185 5.3359 7.17548 5.44953C7.28911 5.56316 7.43388 5.64054 7.59149 5.67189C7.7491 5.70324 7.91247 5.68715 8.06093 5.62566C8.2094 5.56416 8.3363 5.46002 8.42557 5.3264C8.51485 5.19279 8.5625 5.0357 8.5625 4.875C8.5625 4.65951 8.4769 4.45285 8.32453 4.30048C8.17215 4.1481 7.96549 4.0625 7.75 4.0625Z"
                                    svg.fill "#1F2937"
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]

    [<ReactComponent>]
    let WithSteps() =
        let (tooltipStatus, setTooltipStatus) = React.useState(0)
        let tooltipBox = 
            Html.div [
                prop.classes [ "z-20 -mt-20 w-64 absolute transition duration-150 ease-in-out left-0 ml-8 shadow-lg bg-white p-4 rounded" ]
                prop.role.tooltip
                prop.children [
                    Svg.svg [
                        svg.xmlns "http://www.w3.org/2000/svg"
                        Interop.svgAttribute "vresion" "1.1"
                        Interop.svgAttribute "xmlnsXlink" "http://www.w3.org/1999/xlink"
                        svg.classes [ "absolute left-0 -ml-2 bottom-0 top-0 h-full" ]
                        svg.width 9
                        svg.height 16
                        svg.viewBox(0, 0, 9, 16)
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
                                        svg.transform [
                                            transform.translate (-874.000000, -1029.000000)
                                        ]
                                        svg.fill "#FFFFFF"
                                        svg.children [
                                            Svg.g [
                                                svg.id "Group-3-Copy-16"
                                                svg.transform [
                                                    transform.translate (850.000000, 975.000000)
                                                ]
                                                svg.children [
                                                    Svg.g [
                                                        svg.id "Group-2"
                                                        svg.transform [
                                                            transform.translate (24.000000, 0.000000)
                                                        ]
                                                        svg.children [
                                                            Svg.polygon [
                                                                svg.id "Triangle"
                                                                svg.transform [
                                                                    transform.translate (4.500000, 62.000000)
                                                                    transform.rotate -90.000000
                                                                    transform.translate (-4.500000, -62.000000)
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
                        prop.classes [ "text-sm font-bold text-gray-800 pb-1" ]
                        prop.text "Keep track of follow ups"
                    ]
                    Html.p [
                        prop.classes [ "text-xs leading-4 text-gray-600 pb-3" ]
                        prop.text "Reach out to more prospects at the right moment."
                    ]
                    Html.div [
                        prop.classes [ "flex justify-between" ]
                        prop.children [
                            Html.div [
                                prop.classes [ "flex items-center" ]
                                prop.children [
                                    Html.span [
                                        prop.classes [ "text-xs font-bold text-indigo-700" ]
                                        prop.text "Step 1 of 4"
                                    ]
                                ]
                            ]
                            Html.div [
                                prop.classes [ "flex items-center" ]
                                prop.children [
                                    Html.span [
                                        prop.classes [ "text-xs text-gray-600 underline mr-2 cursor-pointer" ]
                                        prop.text "Skip Tour"
                                    ]
                                    Html.button [
                                        prop.classes [ "focus:outline-none bg-indigo-700 transition duration-150 ease-in-out hover:bg-indigo-600 rounded text-white px-5 py-1 text-xs" ]
                                        prop.text "Next"
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
            ]

        Html.div [
            prop.classes [ "flex-col md:flex-row flex items-center md:justify-center" ]
            prop.children [
                Html.div [
                    prop.classes [ "relative mt-20 md:mt-0" ]
                    prop.onMouseEnter (fun e -> setTooltipStatus(1))
                    prop.onMouseLeave (fun e -> setTooltipStatus(0))
                    prop.children [
                        Html.div [
                            prop.classes [ "mr-2 cursor-pointer" ]
                            prop.children [
                                Svg.svg [
                                    Interop.svgAttribute "aria-haspopup" "true"
                                    svg.xmlns "http://www.w3.org/2000/svg"
                                    svg.classes [ "icon icon-tabler icon-tabler-info-circle" ]
                                    svg.width 25
                                    svg.height 25
                                    svg.viewBox(0, 0, 24, 24)
                                    svg.strokeWidth 1.5
                                    svg.stroke "#A0AEC0"
                                    svg.fill "none"
                                    Interop.svgAttribute "strokeLinecap" "round"
                                    Interop.svgAttribute "strokeLinejoin" "round"
                                    svg.children [
                                        Svg.path [
                                            svg.d "M0 0h24v24H0z"
                                            svg.stroke "none"
                                        ]
                                        Svg.circle [
                                            svg.cx 12
                                            svg.cy 12
                                            svg.r 9
                                        ]
                                        Svg.line [
                                            svg.x1 12
                                            svg.y1 8
                                            svg.x2 12.01
                                            svg.y2 8
                                        ]
                                        Svg.polyline [
                                            svg.points "11 12 12 12 12 16 13 16"
                                        ]
                                    ]
                                ]
                            
                                // Show tooltipBox
                                if (tooltipStatus = 0) then Html.none
                                else tooltipBox 
                            ]
                        ]
                    ]
                ]
            ]
        ]