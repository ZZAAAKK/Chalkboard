open System
open System.Windows.Forms

open Window

[<EntryPoint; STAThread>]
let main args =
    let window = new Window()
    Application.Run(window.Form)
    0