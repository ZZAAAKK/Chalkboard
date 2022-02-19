module Window

open System.Windows.Forms
open System.Drawing

open Themes
open MenuStrip
open LocalResourceManager

type Window () =
    let form = new Form()
    let textBox = new RichTextBox()

    let ApplyTheme theme =
        form.BackColor <- theme.BackColour
        textBox.BackColor <- theme.BackColour
        form.ForeColor <- theme.ForeColour
        textBox.ForeColor <- theme.ForeColour
        form.Font <- theme.Font
        textBox.Font <- theme.Font

    let SelectTheme themeName =
        match themeName with
        | "Charcoal" -> Themes.Charcoal
        | "Ocean" -> Themes.Ocean
        | "Rust" -> Themes.Rust
        | "Concrete" -> Themes.Concrete
        | "Terminal" -> Themes.Terminal
        | "High Contrast (Dark)" -> Themes.HighContrastDark
        | "High Contrast (Light)" -> Themes.HighContrastLight
        | _ -> Themes.Default

    let LoadThemeFromUserPreferences = GetTheme()

    let SaveUserTheme (theme : Themes) = SetTheme(theme.Name); theme

    do
        LoadThemeFromUserPreferences |> SelectTheme |> SaveUserTheme |> ApplyTheme
        let menu = new MenuStrip(SaveUserTheme, SelectTheme, ApplyTheme)
        menu.Menu.BackColor <- Color.FromArgb(255, 25, 25, 25)
        form.FormBorderStyle <- FormBorderStyle.None
        form.ClientSize <- new Size(1280, 780)
        textBox.Top <- 25
        textBox.Size <- new Size(form.ClientSize.Width, form.ClientSize.Height - textBox.Top)
        textBox.Anchor <- AnchorStyles.Left + AnchorStyles.Top
        form.Controls.AddRange([| menu.Menu :> Control; textBox |])

    member this.Form = form