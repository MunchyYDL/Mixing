namespace FSharpLib

open System

module Model =

    type Person = {
        Name: string
        DateOfBirth: DateTime
        Children: ResizeArray<Person>
    }

    // A standard F# record of a Car.
    type Car = { // The number of wheels on the car.
        Wheels : int // The brand of the car.
        Brand : string // The x/y of the car in meters
        Dimensions : float * float
    }

    /// A vehicle of some sort.
    type Vehicle =
        | Motorcar of Car   // A car is a type of vehicle.
        | Motorbike of Name:string * EngineSize:float // A bike is also a type of vehicle.
