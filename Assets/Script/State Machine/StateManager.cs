using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public IState currentState;
    public ConveyorBelt conveyorBelt;
    public SceneManagement sceneManagement;

    public AssemblyState assemblyState = new AssemblyState();
    public AutoscrewState autoscrewState = new AutoscrewState();
    public LaserPrintState laserPrintState = new LaserPrintState();
    public PackagingState packagingState = new PackagingState();
    public PrinterState printerState = new PrinterState();
    public VisualInspectionState visualInspectionState = new VisualInspectionState();

    public PrinterController printerController;
    public AssemblyController assemblyController; 
    public AutoscrewController autoscrewController;
    public LaserClawController laserClawController;
    public PackagingController packagingController;
    public InspectionClawController inspectionClawController;

    void Start(){
        printerState.OnEnter(this);
    }
}

public interface IState
{
    public void OnEnter(StateManager stateManager);
    public void OnExit(StateManager stateManager);
}