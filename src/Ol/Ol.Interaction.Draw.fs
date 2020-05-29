module Ol.Interaction.Draw

open Fable.Core
open Ol.Interaction.Pointer
open Ol.Source.Vector
open Ol.Geom
open Ol.Events
open Ol.Feature

type Draw =
    inherit PointerInteraction

type DrawOptions =
    abstract source: VectorSource with get, set
    abstract ``type``: GeometryType with get, set

type DrawStatic =
    [<Emit "new $0($1...)">] abstract Create: DrawOptions -> Draw

type DrawEvent =
    inherit BaseEvent

    abstract feature: Feature

type Events =
    | Drawabort
    | Drawend
    | Drawstart