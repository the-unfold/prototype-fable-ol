module App

open Fable.Core
open Fable.Core.JsInterop
open Browser.Dom
open FableOl

importAll "ol/ol.css"

[<Import("default", "ol/Map")>]
let map: MapStatic = jsNative

[<Import("default", "ol/View")>]
let view: ViewStatic = jsNative

[<Import("default", "ol/layer/Tile")>]
let tileLayer: TileLayerStatic = jsNative

[<Import("default", "ol/source/OSM")>]
let osm: OSMStatic = jsNative

[<Import("fromLonLat", "ol/proj")>]
let fromLonLat: float * float -> float * float = jsNative

let layerOptions = createEmpty<TileLayerOptions>
do layerOptions.source <- osm.Create ()


let viewOptions = createEmpty<ViewOptions>
do viewOptions.center <- fromLonLat (82.921733, 55.029910)
do viewOptions.zoom <- 16.0

let mapOptions = createEmpty<MapOptions>
do mapOptions.target <- "map"
do mapOptions.layers <- [| tileLayer.Create layerOptions |]
do mapOptions.view <- view.Create viewOptions

let theMap = map.Create mapOptions

