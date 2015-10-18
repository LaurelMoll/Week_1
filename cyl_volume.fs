open System // need to read in text and use math values

// equation for cylinder volume
let cylvol (r : float) (h : float) = Math.PI * Math.Pow(r, 2.0) * h

[<EntryPoint>]
let main argv =
    // Read in radius and convert from string to float
    Console.Write("Radius: ")
    let r = Console.ReadLine()
    let r = float r
    
    // Read in height and convert from string to float
    Console.Write("Height: ")
    let h = Console.ReadLine()
    let h = float h
    
    //calculation
    let vol = cylvol r h
    
    //Write output
    Console.Write("The volume of the cylinder is " + (string vol))
    Console.ReadKey() |> ignore
    
    0 //return an integer to exit