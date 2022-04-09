namespace App

open Feliz
open Feliz.Router
open Fable.React

type Components =
    /// <summary>
    /// The simplest possible React component.
    /// Shows a header with the text Hello World
    /// </summary>
    [<ReactComponent>]
    static member HelloWorld() = Html.h1 "Hello World"
    
    [<ReactComponent>]
    static member Wrapper (child: Fable.React.ReactElement) =
        Html.div [
            prop.classes [ "m-8" ]
            prop.children [
                child
            ]
        ]

    [<ReactComponent>]
    static member WrapperS (child: Fable.React.ReactElement, size: int) =
        Html.div [
            prop.classes [ "m-" + (string size) ]
            prop.children [
                child
            ]
        ]

    /// <summary>
    /// A stateful React component that maintains a counter
    /// </summary>
    [<ReactComponent>]
    static member Counter() =
        let (count, setCount) = React.useState(0)
        Html.div [
            Html.h1 count
            Html.button [
                prop.onClick (fun _ -> setCount(count + 1))
                prop.text "Increment"
            ]
        ]

    /// <summary>
    /// A React component that uses Feliz.Router
    /// to determine what to show based on the current URL
    /// </summary>
    [<ReactComponent>]
    static member Router() =
        let (currentUrl, updateUrl) = React.useState(Router.currentUrl())
        React.router [
            router.onUrlChanged updateUrl
            router.children [
                match currentUrl with
                | [ ] -> Html.h1 "Index"
                | [ "hello" ] -> Components.HelloWorld()
                | [ "counter" ] -> Components.Counter()
                | [ "button" ] -> Components.Button.Small()
                | [ "popover" ] -> Components.Popover.WithData()
                | [ "progressbar" ] -> Components.Wrapper(Components.ProgressBar.ThinWithSteps())
                | [ "search" ] -> Components.Search.Small()
                | [ "tooltip" ] -> Components.WrapperS(Components.Tooltip.WithSteps(), 10)
                | [ "badge" ] -> Components.Wrapper(Components.Badge.WithCloseButton())
                | [ "avatar" ] -> Components.Wrapper(Components.Avatar.WithCircleStacked())
                | [ "calendar" ] -> Components.Calendar.Small()
                | otherwise -> Html.h1 "Not found"
            ]
        ]