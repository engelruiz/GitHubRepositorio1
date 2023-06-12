// Programa que permita visualizar los departamentos de nicaragua
// con su cantidad poblacional
// Encuentre: mayor, menor, sumas y ordene los datos
using System;
using System.Collections;
using Departamento;

List<depto> IstDeptos = new List<depto>(){
new depto("Boaco",185013),
new depto("Carazo",197139),
new depto("Chinandega",439906),
new depto("chontales",190863),
new depto("Costa caribe Norte",530586),
new depto("Costa Caribe Sur",414543),
new depto("Esteli",229866),
new depto("Granada",214317),
new depto("Jinotega",475630),
new depto("Leon",421050),
new depto("Madriz",174744),
new depto("Managua",1546939),
new depto("Masaya",391903),
new depto("Matagalpa",593503),
new depto("Nueva Segovia",271581),
new depto("Rio San Juan",135446),
new depto("Rivas", 182645 )
};

depto minDepto = IstDeptos.OrderBy(d => d.population).First();
depto maxDepto = IstDeptos.OrderBy(d => d.population).Last();
//Ordenar los departamentos
var DeptOrdenado = IstDeptos.OrderBy(d => d.population);
//Mostrar departamentos ordenados 
foreach (var item in DeptOrdenado)
    Console.WriteLine($"{item.Name,-20}==>{item.population,10:NO}");
//Mostrar el mayor y el menor 
Console.WriteLine($"Dpto con menor poblacion: {minDepto.Name}");
Console.WriteLine($"max con menor poblacion: {minDepto.Name}");
//sumar todas las poblaciones con SUM de LINQ
int total = IstDeptos.Select(d => d.population).Sum();
Console.WriteLine($"Poblacion General:{total:NO}");