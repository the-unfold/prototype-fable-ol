module Ol.Geom

open Fable.Core

[<StringEnum>]
type GeometryType = 
    | [<CompiledName("Point")>] Point 
    | [<CompiledName("LineString")>] LineString 
    | [<CompiledName("LinearRing")>] LinearRing
    | [<CompiledName("Polygon")>] Polygon 
    | [<CompiledName("MultiLineString")>] MultiLineString 
    | [<CompiledName("MultiPolygon")>] MultiPolygon 
    | [<CompiledName("GeometryCollection")>] GeometryCollection 
    | [<CompiledName("Circle")>] Circle