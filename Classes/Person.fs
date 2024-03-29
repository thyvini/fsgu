﻿namespace Classes

open System

type Person(name: string, favoriteColorName: string) =
    do
        if String.IsNullOrWhiteSpace name then
            raise <| ArgumentException("Name cannot be null", "message")

    let favoriteColor =
        if String.IsNullOrWhiteSpace favoriteColorName then
            "(None)"
        else
            favoriteColorName

    member this.Description() =
        sprintf "Name: %s, favorite color: %s" name favoriteColor
