namespace App
namespace Components

module Avatar =
    open Feliz
    open Browser.Types

    [<ReactComponent>]
    let WithCircleStacked() = 
        Html.div [
            prop.classes [ "px-6 flex items-center flex-no-wrap" ]
            prop.children [
                Html.div [
                    prop.classes [ "w-12 h-12 bg-cover bg-center rounded-md" ]
                    prop.children [
                        Html.img [
                            prop.src "https://tuk-cdn.s3.amazonaws.com/assets/components/avatars/a_4_0.png"
                            prop.alt ""
                            prop.classes [ "h-full w-full overflow-hidden object-cover rounded-full border-2 border-white dark:border-gray-700 shadow" ]
                        ]
                    ]
                ]
                Html.div [
                    prop.classes [ "w-12 h-12 bg-cover rounded-md -ml-2" ]
                    prop.children [
                        Html.img [
                            prop.src "https://tuk-cdn.s3.amazonaws.com/assets/components/avatars/a_4_1.png"
                            prop.alt ""
                            prop.classes [ "h-full w-full overflow-hidden object-cover rounded-full border-2 border-white dark:border-gray-700 shadow" ]
                        ]
                    ]
                ]
                Html.div [
                    prop.classes [ "w-12 h-12 bg-cover rounded-md bg-center -ml-2" ]
                    prop.children [
                        Html.img [
                            prop.src "https://tuk-cdn.s3.amazonaws.com/assets/components/avatars/a_4_2.png"
                            prop.alt ""
                            prop.classes [ "h-full w-full overflow-hidden object-cover rounded-full border-2 border-white dark:border-gray-700 shadow" ]
                        ]
                    ]
                ]
                Html.div [
                    prop.classes [ "w-12 h-12 bg-cover rounded-md -ml-2" ]
                    prop.children [
                        Html.img [
                            prop.src "https://tuk-cdn.s3.amazonaws.com/assets/components/avatars/a_4_3.png"
                            prop.alt ""
                            prop.classes [ "h-full w-full overflow-hidden object-cover object-center rounded-full border-2 border-white dark:border-gray-700 shadow" ]
                        ]
                    ]
                ]
                Html.div [
                    prop.classes [ "w-12 h-12 bg-cover rounded-md -ml-2" ]
                    prop.children [
                        Html.img [
                            prop.src "https://tuk-cdn.s3.amazonaws.com/assets/components/avatars/a_4_4.png"
                            prop.alt ""
                            prop.classes [ "h-full w-full overflow-hidden object-cover object-center rounded-full border-2 border-white dark:border-gray-700 shadow" ]
                        ]
                    ]
                ]
            ]
        ]