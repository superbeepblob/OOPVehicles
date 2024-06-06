Vytvorte:

Třídu Vehicle: Atributy: Model, Year, RegistrationNumber

Třídy Car, Bus a Motorcycle jako potomky třídy Vehicle:
Třída Car bude mít navíc atribut NumberOfDoors.
Třída Bus bude mít navíc atribut Capacity.
Třída Motorcycle bude mít navíc atribut EngineCapacity.

Třídu VehicleShop:
Atribut: List<Vehicle> VehicleList
Metody:
AddVehicle(Vehicle vehicle): Přidá vozidlo do seznamu.
ShowVehicleList(): Vrátí textovou reprezentaci seznamu vozidel.
SaveToFile(string path): Uloží seznam vozidel do textového souboru.
