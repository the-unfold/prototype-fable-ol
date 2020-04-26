module FableOl

open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop

    type [<AllowNullLiteral>] Coordinate =
        inherit Object

    type [<AllowNullLiteral>] View =
        inherit Object

        abstract getCenter: unit -> Coordinate
        abstract setCenter: center: Coordinate -> unit
        abstract getZoom: unit -> float
        abstract setZoom: zoom: float -> unit

    type [<AllowNullLiteral>] Map =
        inherit Object

    type [<AllowNullLiteral>] Layer =
        inherit Object

    type [<AllowNullLiteral>] OSM =
        inherit Object

    type ViewOptions = {
        center: float * float
        zoom: float
    }

    type MapOptions = {
        target: string
        layers: Layer array
        view: View
    }

    type TileLayerOptions = {
        source: OSM
    }
    // type [<AllowNullLiteral>] OSMOptions =

    // type [<AllowNullLiteral>] UrlTile =
    //     inherit Tile

    // type [<AllowNullLiteral>] TileImage =
    //     inherit UrlTile

    // type [<AllowNullLiteral>] XYZ =
    //     inherit TileImage

   

    type [<AllowNullLiteral>] OSMStatic =
        [<Emit "new $0()">] abstract Create: unit -> OSM

    type [<AllowNullLiteral>] MapStatic =
        /// <param name="options">Map options.</param>
        [<Emit "new $0($1...)">] abstract Create: options: MapOptions -> Map

    type [<AllowNullLiteral>] ViewStatic =
        [<Emit "new $0($1...)">] abstract Create: options: ViewOptions -> View

    type [<AllowNullLiteral>] TileLayerStatic =
        [<Emit "new $0($1...)">] abstract Create: options: TileLayerOptions -> Layer