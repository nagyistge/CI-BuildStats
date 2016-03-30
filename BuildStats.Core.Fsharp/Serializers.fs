﻿namespace BuildStats.Core.Fsharp

open Newtonsoft.Json

type ISerializer =
    abstract member Deserialize<'T> : string -> 'T

type JsonSerializer() =
    interface ISerializer with
        member this.Deserialize<'T>(content : string) =
            JsonConvert.DeserializeObject<'T>(content)