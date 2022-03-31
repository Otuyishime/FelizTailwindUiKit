namespace App
namespace Components

module Button =
    open Feliz

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
            ]
            prop.text "Small Button"
            prop.tabIndex 0
        ]

    [<ReactComponent>]
    let Standard() = 
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
                "px-6" 
                "py-2" 
                "text-sm"
                "shadow"
            ]
            prop.text "Standard Button"
            prop.tabIndex 0
        ]

    [<ReactComponent>]
    let Group() =
        Html.div [
            prop.classes [ "flex items-start mx-2 my-2" ]
            prop.children [
                Html.div [
                    prop.classes [ "border border-gray-300 flex text-gray-300 shadow rounded" ]
                    prop.role.tab
                    prop.ariaLabel "filter content by"
                    prop.children [
                        Html.button [
                            prop.classes [ "py-2 px-6 flex items-center justify-center text-gray-800 text-sm rounded" ]
                            prop.role.tab
                            prop.text "Week"
                        ]
                        Html.button [
                            prop.classes [ "py-2 px-6 flex items-center justify-center text-gray-800 text-sm rounded" ]
                            prop.role.tab
                            prop.text "Month"
                        ]
                        Html.button [
                            prop.classes [ "py-2 px-6 flex items-center justify-center text-gray-800 text-sm rounded" ]
                            prop.role.tab
                            prop.text "Year"
                        ]
                    ]
                ]
            ]
        ]