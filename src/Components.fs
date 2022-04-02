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
            prop.classes [ "my-8" ]
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
                | otherwise -> Html.h1 "Not found"
            ]
        ]