module LocalResourceManager

open System.Resources
open System.Reflection
open Configuration

let GetResource<'T>(resourceName) : 'T =
    ResourceManager("Chalkboard.Resources.Resource", Assembly.GetCallingAssembly()).GetObject(resourceName) :?> 'T

let GetTheme() : string = AppConfigObj.ThemeName

let SetTheme(value : string) = AppConfigObj.ThemeName <- value