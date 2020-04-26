module FableOl

open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop

type Coordinate =
    inherit Object

type View =
    inherit Object

    abstract getCenter: unit -> Coordinate
    abstract setCenter: center: Coordinate -> unit
    abstract getZoom: unit -> float
    abstract setZoom: zoom: float -> unit

type Map =
    inherit Object

type Layer =
    inherit Object

type OSM =
    inherit Object

type VectorSource =
    inherit Object

type ViewOptions = 
    abstract center: float * float with get, set
    abstract zoom: float with get, set

type MapOptions = 
    abstract target: string with get, set
    abstract layers: Layer array with get, set
    abstract view: View with get, set

type VectorSourceOptions =
    abstract wrapX: bool with get, set

type TileLayerOptions = 
    abstract source: OSM with get, set

type VectorLayerOptions =
    abstract source: VectorSource with get, set

type OSMStatic =
    [<Emit "new $0()">] abstract Create: unit -> OSM

type VectorSourceStatic =
    [<Emit "new $0($1...)">] abstract Create: VectorSourceOptions -> VectorSource

type MapStatic =
    /// <param name="options">Map options.</param>
    [<Emit "new $0($1...)">] abstract Create: options: MapOptions -> Map

type ViewStatic =
    [<Emit "new $0($1...)">] abstract Create: options: ViewOptions -> View

type TileLayerStatic =
    [<Emit "new $0($1...)">] abstract Create: options: TileLayerOptions -> Layer

type VectorLayerStatic = 
    [<Emit "new $0($1...)">] abstract Create: options: VectorLayerOptions -> Layer