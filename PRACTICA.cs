//practica
//hola hola hola


arraylist listacompleta = new ArrayList();
//se crea la lista completa de todo
//inciso a
arraylist alumno = new arraylist();
alumno.add(dni);
alumno.add(escuela);
// se crea la lista alumno con los atributos
listacompleta.add(alumno);
// se añade la lista alumno a la lista completa para no tener problemas de datos en la lista


//inciso B
int dni;
int i=0;
bool bandera=false;
//bandera se vuelve true cuando alumno[0] es igual al dni buscado
//después en base a si bandera es true o false borra

foreach(arraylist alumnos in listacompleta)
{
	if( ((int)alumno[0]) ==dni) 
	{
		bandera=true;
		break;
	}
		else
			i++;
}
if (bandera==true) listacompleta.RemoveAt (i);


//inciso 
console.WriteLine(listacompleta.count());



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



hola de nuevo