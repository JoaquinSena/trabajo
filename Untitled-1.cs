//inciso D
//imprimir escuela por orden alfabetico
foreach (ArrayList alumno in listacompleta)
{
    escuela.add(alumno[1]);
}
console.WriteLine(escuela.count());
//inciso E
escuela.sort();
int cantidadescuela=escuela.count();
string nombreActual, nombreAnterior;
for (int i=0; cantidadescuela; i++)
{
    nombreActual=(string)escuela[i];
    if (nombreActual == nombreAnterior) console.WriteLine(nombreActual);
    nombreAnterior = nombreActual;
}



//hola