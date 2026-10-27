Parcel first = new Parcel("MX-101", "Luna Station", 12);
Parcel second = new Parcel("MX-102", "Crater Lab", 7);
Parcel third = new Parcel("MX-107", "Monk Storage", 15);

Console.WriteLine($"{first.TrackingCode} -> {first.Destination} ({first.Weight} kg)");
Console.WriteLine($"{second.TrackingCode} -> {second.Destination} ({second.Weight} kg)");
Console.WriteLine($"{third.TrackingCode} -> {third.Destination} ({third.Weight} kg)");
