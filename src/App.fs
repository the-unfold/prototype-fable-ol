module App

open Fable.Core
open Fable.Core.JsInterop
open Browser.Dom
open FableOl

[<Import("default", "ol/Map")>]
let map: MapStatic = jsNative

[<Import("default", "ol/View")>]
let view: ViewStatic = jsNative

[<Import("default", "ol/layer/Tile")>]
let tileLayer: TileLayerStatic = jsNative

[<Import("default", "ol/source/OSM")>]
let osm: OSMStatic = jsNative

let layerOptions = {
    source = osm.Create ()
}

let viewOptions = {
    center = (0.0, 0.0)
    zoom = 1.0
}

let mapOptions: MapOptions = {
    target = "map"
    layers = [| tileLayer.Create layerOptions |]
    view = view.Create viewOptions
}

let theMap = map.Create mapOptions

console.log theMap

// Mutable variable to count the number of times we clicked the button
let mutable count = 0

// Get a reference to our button and cast the Element to an HTMLButtonElement
let myButton = document.querySelector(".my-button") :?> Browser.Types.HTMLButtonElement

// Register our listener
myButton.onclick <- fun _ ->
    count <- count + 1
    myButton.innerText <- sprintf "You clicked: %i time(s)" count

