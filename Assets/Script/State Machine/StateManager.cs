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
    public InactiveState inactiveState = new InactiveState();

    public PrinterController printerController;
    public AssemblyController assemblyController; 
    public AutoscrewController autoscrewController;
    public LaserClawController laserClawController;
    public PackagingController packagingController;
    public InspectionClawController inspectionClawController;

    public void StartProduction(){
        if(currentState == inactiveState){
            currentState.UpdateState(this);
        }
    }

    public void ChangeState(IState newState){
        if(currentState != null){
            currentState.OnExit(this);
        }
        currentState = newState;
        currentState.OnEnter(this);
    }

    void OnTriggerEnter(Collider other) {
        if(other.tag == "EndOfState"){
            currentState.UpdateState(this);
        }
    }
}

public interface IState
{
    public void OnEnter(StateManager stateManager);
    public void UpdateState(StateManager stateManager);
    public void OnExit(StateManager stateManager);
}