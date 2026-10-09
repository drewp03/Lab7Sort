using UnityEngine;
using System.Diagnostics;
using System;
using SortCSharpPlugin;

public class FunctionTimer : MonoBehaviour
{
    [SerializeField] private InEngineSort inEngineSort;
    [SerializeField] private SortCSharpPlugin.SortCSharpPlugin plugin;

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
        long elapsedMilliseconds = stopwatch.ElapsedMilliseconds; // Get the elapsed time
        UnityEngine.Debug.Log($"In engine code took {elapsedMilliseconds} ms to execute.");

        stopwatch.Reset();

        stopwatch.Start(); // Start timing
        CSharpPlugin(); // Call the function you want to measure
        stopwatch.Stop();  // Stop timing
        elapsedMilliseconds = stopwatch.ElapsedMilliseconds; // Get the elapsed time
        UnityEngine.Debug.Log($"C# Plugin took {elapsedMilliseconds} ms to execute.");



    }

    void InEngine()
    {
        inEngineSort.TestSort(inEngineSort.massiveArray);
    }

    void CSharpPlugin()
    {
        plugin.TestSort(plugin.massiveArray);
    }
}
