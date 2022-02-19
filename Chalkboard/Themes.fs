module Themes

open System.Drawing

type Themes = 
    { Name : string; BackColour : Color; ForeColour : Color; Font : Font; }
    static member Default = { Name = "Default"; BackColour = Color.FromArgb(255, 25, 25, 25); ForeColour = Color.White; Font = new Font("Segoe UI", 12f) }
    static member Charcoal = { Name = "Charcoal"; BackColour = Color.FromArgb(255, 55, 55, 55); ForeColour = Color.White; Font = new Font("Segoe UI", 12f) }
    static member Ocean = { Name = "Ocean"; BackColour = Color.FromArgb(255, 36, 115, 115); ForeColour = Color.White; Font = new Font("Segoe UI", 12f) }
    static member Rust = { Name = "Rust"; BackColour = Color.Black; ForeColour = Color.FromArgb(255, 250, 147, 37); Font = new Font("Segoe UI", 12f) }
    static member Concrete = { Name = "Concrete"; BackColour = Color.FromArgb(255, 237, 237, 237); ForeColour = Color.Black; Font = new Font("Segoe UI", 12f) }
    static member Terminal = { Name = "Terminal"; BackColour = Color.Black; ForeColour = Color.FromArgb(255, 15, 191, 71); Font = new Font("Segoe UI", 12f) }
    static member HighContrastDark = { Name = "High Contrast (Dark)"; BackColour = Color.Black; ForeColour = Color.White; Font = new Font("Segoe UI", 12f) }
    static member HighContrastLight = { Name = "High Contrast (Light)"; BackColour = Color.White; ForeColour = Color.Black; Font = new Font("Segoe UI", 12f) }