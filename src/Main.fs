module Main

open Feliz
open App
open Browser.Dom
open Fable.Core.JsInterop

importSideEffects "./styles/global.scss"
importSideEffects "./styles/tailwind.css"

ReactDOM.render(
    Components.Router(),
    document.getElementById "feliz-app"
)