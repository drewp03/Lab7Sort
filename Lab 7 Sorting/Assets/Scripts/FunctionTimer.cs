using UnityEngine;
using System.Diagnostics;
using System;

public class FunctionTimer : MonoBehaviour
{
    [SerializeField] private InEngineSort inEngineSort;

    void Start()
    {
        MeasureFunctionExecutionTime();
    }

    void MeasureFunctionExecutionTime()
    {
        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start(); // Start timing
        InEngine(); // Call the function you want to measure
        stopwatch.Stop();  // Stop timing

        stopwatch.Reset();

        stopwatch.Start(); // Start timing
        CSharpPlugin(); // Call the function you want to measure
        stopwatch.Stop();  // Stop timing

        // Get the elapsed time
        long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
        UnityEngine.Debug.Log($"MyFunctionToTest took {elapsedMilliseconds} ms to execute.");
    }

    void InEngine()
    {
        inEngineSort.TestSort(inEngineSort.massiveArray);
    }

    void CSharpPlugin()
    {

    }
}
