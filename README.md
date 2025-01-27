# Usando_Task.Factory.StartNew

Este proyecto demuestra cómo usar `Task.Factory.StartNew` para ejecutar una tarea en segundo plano y cómo asegurar que el programa principal espere a que la tarea se complete antes de finalizar.

## Descripción

El código crea una tarea utilizando `Task.Factory.StartNew` con la opción `TaskCreationOptions.LongRunning`. Esta tarea realiza una operación que simula trabajo en segundo plano, imprimiendo números del 0 al 9. Sin embargo, el problema es que la línea "Tarea completada." podría no imprimirse si no se espera a que la tarea termine.

### Problema

La tarea se ejecuta de manera asíncrona, lo que significa que el hilo principal puede continuar su ejecución y finalizar el programa antes de que la tarea haya completado su trabajo. Esto resulta en que el mensaje "Tarea completada." no se imprime en algunos casos.

### Solución

Para solucionar este problema, se usa `await task;` para esperar a que la tarea termine antes de continuar con la ejecución del programa. Esto garantiza que la tarea se complete antes de que se imprima el mensaje "Tarea completada."

## Cómo Funciona el Código

1. **Tarea en Segundo Plano:** Se utiliza `Task.Factory.StartNew` para iniciar una tarea que imprimirá números del 0 al 9.
2. **Esperar a la Tarea:** Para asegurarse de que el mensaje "Tarea completada." se imprima solo después de que la tarea haya finalizado, se usa `await task;`.
3. **Tarea Completa:** Una vez que la tarea termine, el programa continuará y se imprimirá el mensaje "Tarea completada."

   ![Screenshot 2025-01-27 174724](https://github.com/user-attachments/assets/c2303d72-662d-4472-ac24-d35cab6b4506)
