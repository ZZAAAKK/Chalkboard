module Configuration

open FSharp.Data
open System.Xml.Linq

type AppConfigObj() =
    static let [<Literal>] configFile = "config.xml"
    static let config = XmlProvider<configFile>.Load(configFile.ToString())
    static member ThemeName 
        with get() = config.Strings.ThemeName
        and set(value : string) = config.Strings.XElement.SetElementValue(XName.Get("ThemeName"), value); config.XElement.Save(configFile)