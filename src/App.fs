module App

open Fable.Core
open Fable.Core.JsInterop
open Browser.Dom
open FableOl

importAll "ol/ol.css"

[<ImportDefault("ol/Map")>]
let map: MapStatic = jsNative

[<ImportDefault("ol/View")>]
let view: ViewStatic = jsNative

[<ImportDefault("ol/layer/Tile")>]
let tileLayer: TileLayerStatic = jsNative

[<ImportDefault("ol/layer/Vector")>]
let vectorLayer: VectorLayerStatic = jsNative

[<ImportDefault("ol/source/OSM")>]
let osm: OSMStatic = jsNative

[<ImportDefault("ol/source/Vector")>]
let vectorSource: VectorSourceStatic = jsNative

[<Import("fromLonLat", "ol/proj")>]
let fromLonLat: float * float -> float * float = jsNative

let tileLayerOptions = jsOptions<TileLayerOptions>(fun x -> 
    x.source <- osm.Create ())

let vectorSourceOptions = jsOptions<VectorSourceOptions>(fun x -> 
    x.wrapX <- false)

let vectorLayerOptions = jsOptions<VectorLayerOptions>(fun x ->
    x.source <- vectorSource.Create vectorSourceOptions)

let viewOptions = jsOptions<ViewOptions>(fun x ->
    x.center <- fromLonLat (82.921733, 55.029910)
    x.zoom <- 16.0)

let mapOptions = jsOptions<MapOptions>(fun x -> 
    x.target <- "map"
    x.layers <- [| tileLayer.Create tileLayerOptions; vectorLayer.Create vectorLayerOptions |]
    x.view <- view.Create viewOptions)

let theMap = map.Create mapOptions

