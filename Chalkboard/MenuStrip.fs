module MenuStrip

open System
open System.Windows.Forms
open System.Drawing

open Themes
open LocalResourceManager

type MenuStrip (_saveTheme_Callback, _themeSelectCallback : string -> Themes, _applyThemeCallback : Themes -> unit) =
    let menuNew = new ToolStripMenuItem("", GetResource<Image>("New"))
    let menuOpen = new ToolStripMenuItem("", GetResource<Image>("Open"))
    let menuSave = new ToolStripMenuItem("", GetResource<Image>("Save"))
    let menuSaveAs = new ToolStripMenuItem("", GetResource<Image>("SaveAs"))
    let menuClose = new ToolStripMenuItem("", GetResource<Image>("Close"))
    let themeDefault = new ToolStripMenuItem("Default")
    let themeCharcoal = new ToolStripMenuItem("Charcoal")
    let themeOcean = new ToolStripMenuItem("Ocean")
    let themeRust = new ToolStripMenuItem("Rust")
    let themeConcrete = new ToolStripMenuItem("Concrete")
    let themeTerminal = new ToolStripMenuItem("Terminal")
    let themeHighContrastDark = new ToolStripMenuItem("High Contrast (Dark)")
    let themeHighContrastLight = new ToolStripMenuItem("High Contrast (Light)")
    let menuTheme = new ToolStripMenuItem("", GetResource<Image>("Theme"), [| themeDefault :> ToolStripItem; themeCharcoal :> ToolStripItem; themeOcean :> ToolStripItem; themeRust :> ToolStripItem; themeConcrete :> ToolStripItem; themeTerminal :> ToolStripItem; themeHighContrastDark :> ToolStripItem; themeHighContrastLight :> ToolStripItem |])
    let menu = new ToolStrip([| menuNew :> ToolStripItem; menuOpen :> ToolStripItem; menuSave :> ToolStripItem; menuSaveAs :> ToolStripItem; menuClose :> ToolStripItem; menuTheme :> ToolStripItem |])
    do
        menuNew.ToolTipText <- "New"
        menuNew.ShortcutKeys <- Keys.Control + Keys.N
        menuNew.ShortcutKeyDisplayString <- "Ctrl + N"
        menuOpen.ToolTipText <- "Open"
        menuOpen.ShortcutKeys <- Keys.Control + Keys.O
        menuOpen.ShortcutKeyDisplayString <- "Ctrl + O"
        menuSave.ToolTipText <- "Save"
        menuSave.ShortcutKeys <- Keys.Control + Keys.S
        menuSave.ShortcutKeyDisplayString <- "Ctrl + S"
        menuSaveAs.ToolTipText <- "Save As"
        menuSaveAs.ShortcutKeys <- Keys.Control + Keys.LShiftKey + Keys.S
        menuSaveAs.ShortcutKeyDisplayString <- "Ctrl + Shift + S"
        menuClose.ToolTipText <- "Close"
        menuClose.ShortcutKeys <- Keys.Control + Keys.W
        menuClose.ShortcutKeyDisplayString <- "Ctrl + W"
        menuTheme.ToolTipText <- "Theme"
        menuTheme.ShortcutKeys <- Keys.Control + Keys.W
        menuTheme.ShortcutKeyDisplayString <- "Ctrl + W"
        menuTheme.Image <- GetResource<Image>("Theme")
        themeDefault.Click |> Event.add(fun _ -> _themeSelectCallback(themeDefault.Text) |> _saveTheme_Callback |> _applyThemeCallback)
        themeCharcoal.Click |> Event.add(fun _ -> _themeSelectCallback(themeCharcoal.Text) |> _saveTheme_Callback |> _applyThemeCallback)
        themeOcean.Click |> Event.add(fun _ -> _themeSelectCallback(themeOcean.Text) |> _saveTheme_Callback |> _applyThemeCallback)
        themeRust.Click |> Event.add(fun _ -> _themeSelectCallback(themeRust.Text) |> _saveTheme_Callback |> _applyThemeCallback)
        themeConcrete.Click |> Event.add(fun _ -> _themeSelectCallback(themeConcrete.Text) |> _saveTheme_Callback |> _applyThemeCallback)
        themeTerminal.Click |> Event.add(fun _ -> _themeSelectCallback(themeTerminal.Text) |> _saveTheme_Callback |> _applyThemeCallback)
        themeHighContrastDark.Click |> Event.add(fun _ -> _themeSelectCallback(themeHighContrastDark.Text) |> _saveTheme_Callback |> _applyThemeCallback)
        themeHighContrastLight.Click |> Event.add(fun _ -> _themeSelectCallback(themeHighContrastLight.Text) |> _saveTheme_Callback |> _applyThemeCallback)
        menu.ShowItemToolTips <- true
        menu.GripStyle <- ToolStripGripStyle.Hidden
        menu.Anchor <- AnchorStyles.Top + AnchorStyles.Left

    member this.Menu = menu