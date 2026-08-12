# Vcenter.ViJson.OpenApi.Api.VirtualMachineApi

All URIs are relative to *https://localhost/sdk/vim25/9.1.0.0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**VirtualMachineAcquireMksTicket**](VirtualMachineApi.md#virtualmachineacquiremksticket) | **POST** /VirtualMachine/{moId}/AcquireMksTicket | Creates and returns a one-time credential used in establishing a remote mouse-keyboard-screen connection to this virtual machine.  |
| [**VirtualMachineAcquireTicket**](VirtualMachineApi.md#virtualmachineacquireticket) | **POST** /VirtualMachine/{moId}/AcquireTicket | Creates and returns a one-time credential used in establishing a specific connection to this virtual machine, for example, a ticket type of mks can be used to establish a remote mouse-keyboard-screen connection.  |
| [**VirtualMachineAnswerVM**](VirtualMachineApi.md#virtualmachineanswervm) | **POST** /VirtualMachine/{moId}/AnswerVM | Responds to a question that is blocking this virtual machine.  |
| [**VirtualMachineApplyEvcModeVMTask**](VirtualMachineApi.md#virtualmachineapplyevcmodevmtask) | **POST** /VirtualMachine/{moId}/ApplyEvcModeVM_Task | Applies the EVC mode masks to the virtual machine.  |
| [**VirtualMachineAttachDiskTask**](VirtualMachineApi.md#virtualmachineattachdisktask) | **POST** /VirtualMachine/{moId}/AttachDisk_Task | Attach an existing disk to this virtual machine.  |
| [**VirtualMachineCheckCustomizationSpec**](VirtualMachineApi.md#virtualmachinecheckcustomizationspec) | **POST** /VirtualMachine/{moId}/CheckCustomizationSpec | Checks the customization specification against the virtual machine configuration.  |
| [**VirtualMachineCloneVMTask**](VirtualMachineApi.md#virtualmachineclonevmtask) | **POST** /VirtualMachine/{moId}/CloneVM_Task | Creates a clone of this virtual machine.  |
| [**VirtualMachineConsolidateVMDisksTask**](VirtualMachineApi.md#virtualmachineconsolidatevmdiskstask) | **POST** /VirtualMachine/{moId}/ConsolidateVMDisks_Task | Consolidate the virtual disk files of the virtual machine by finding hierarchies of redo logs that can be combined without violating data dependency.  |
| [**VirtualMachineCreateScreenshotTask**](VirtualMachineApi.md#virtualmachinecreatescreenshottask) | **POST** /VirtualMachine/{moId}/CreateScreenshot_Task | Create a screen shot of a virtual machine.  |
| [**VirtualMachineCreateSecondaryVMExTask**](VirtualMachineApi.md#virtualmachinecreatesecondaryvmextask) | **POST** /VirtualMachine/{moId}/CreateSecondaryVMEx_Task | Creates a secondary virtual machine to be part of this fault tolerant group.  |
| [**VirtualMachineCreateSecondaryVMTask**](VirtualMachineApi.md#virtualmachinecreatesecondaryvmtask) | **POST** /VirtualMachine/{moId}/CreateSecondaryVM_Task | Creates a secondary virtual machine to be part of this fault tolerant group.  |
| [**VirtualMachineCreateSnapshotExTask**](VirtualMachineApi.md#virtualmachinecreatesnapshotextask) | **POST** /VirtualMachine/{moId}/CreateSnapshotEx_Task | Creates a new snapshot of this virtual machine.  |
| [**VirtualMachineCreateSnapshotTask**](VirtualMachineApi.md#virtualmachinecreatesnapshottask) | **POST** /VirtualMachine/{moId}/CreateSnapshot_Task | Creates a new snapshot of this virtual machine.  |
| [**VirtualMachineCryptoUnlockTask**](VirtualMachineApi.md#virtualmachinecryptounlocktask) | **POST** /VirtualMachine/{moId}/CryptoUnlock_Task | Unlocks an encrypted virtual machine by sending the encryption keys for the Virtual Machine Home and all the Virtual Disks to the ESX Server.  |
| [**VirtualMachineCustomizeVMTask**](VirtualMachineApi.md#virtualmachinecustomizevmtask) | **POST** /VirtualMachine/{moId}/CustomizeVM_Task | Customizes a virtual machine&#39;s guest operating system.  |
| [**VirtualMachineDefragmentAllDisks**](VirtualMachineApi.md#virtualmachinedefragmentalldisks) | **POST** /VirtualMachine/{moId}/DefragmentAllDisks | Defragment all virtual disks attached to this virtual machine.  |
| [**VirtualMachineDestroyTask**](VirtualMachineApi.md#virtualmachinedestroytask) | **POST** /VirtualMachine/{moId}/Destroy_Task | Destroys this object, deleting its contents and removing it from its parent folder (if any).  |
| [**VirtualMachineDetachDiskTask**](VirtualMachineApi.md#virtualmachinedetachdisktask) | **POST** /VirtualMachine/{moId}/DetachDisk_Task | Detach a disk from this virtual machine.  |
| [**VirtualMachineDisableSecondaryVMTask**](VirtualMachineApi.md#virtualmachinedisablesecondaryvmtask) | **POST** /VirtualMachine/{moId}/DisableSecondaryVM_Task | Disables the specified secondary virtual machine in this fault tolerant group.  |
| [**VirtualMachineDropConnections**](VirtualMachineApi.md#virtualmachinedropconnections) | **POST** /VirtualMachine/{moId}/DropConnections | Force the virtual machine to drop the specified connections.  |
| [**VirtualMachineEnableSecondaryVMTask**](VirtualMachineApi.md#virtualmachineenablesecondaryvmtask) | **POST** /VirtualMachine/{moId}/EnableSecondaryVM_Task | Enables the specified secondary virtual machine in this fault tolerant group.  |
| [**VirtualMachineEstimateStorageForConsolidateSnapshotsTask**](VirtualMachineApi.md#virtualmachineestimatestorageforconsolidatesnapshotstask) | **POST** /VirtualMachine/{moId}/EstimateStorageForConsolidateSnapshots_Task | Estimate the temporary space required to consolidation disk files.  |
| [**VirtualMachineExportVm**](VirtualMachineApi.md#virtualmachineexportvm) | **POST** /VirtualMachine/{moId}/ExportVm | Obtains an export lease on this virtual machine.  |
| [**VirtualMachineExtractOvfEnvironment**](VirtualMachineApi.md#virtualmachineextractovfenvironment) | **POST** /VirtualMachine/{moId}/ExtractOvfEnvironment | Returns the OVF environment for a virtual machine.  |
| [**VirtualMachineGetAlarmActionsEnabled**](VirtualMachineApi.md#virtualmachinegetalarmactionsenabled) | **GET** /VirtualMachine/{moId}/alarmActionsEnabled | Whether alarm actions are enabled for this entity.  |
| [**VirtualMachineGetAvailableField**](VirtualMachineApi.md#virtualmachinegetavailablefield) | **GET** /VirtualMachine/{moId}/availableField | List of custom field definitions that are valid for the object&#39;s type.  |
| [**VirtualMachineGetCapability**](VirtualMachineApi.md#virtualmachinegetcapability) | **GET** /VirtualMachine/{moId}/capability | Information about the runtime capabilities of this virtual machine.  |
| [**VirtualMachineGetConfig**](VirtualMachineApi.md#virtualmachinegetconfig) | **GET** /VirtualMachine/{moId}/config | Configuration of this virtual machine, including the name and UUID.  |
| [**VirtualMachineGetConfigIssue**](VirtualMachineApi.md#virtualmachinegetconfigissue) | **GET** /VirtualMachine/{moId}/configIssue | Current configuration issues that have been detected for this entity.  |
| [**VirtualMachineGetConfigStatus**](VirtualMachineApi.md#virtualmachinegetconfigstatus) | **GET** /VirtualMachine/{moId}/configStatus | The configStatus indicates whether or not the system has detected a configuration issue involving this entity.  |
| [**VirtualMachineGetCustomValue**](VirtualMachineApi.md#virtualmachinegetcustomvalue) | **GET** /VirtualMachine/{moId}/customValue | Custom field values.  |
| [**VirtualMachineGetDatastore**](VirtualMachineApi.md#virtualmachinegetdatastore) | **GET** /VirtualMachine/{moId}/datastore | A collection of references to the subset of datastore objects in the datacenter that is used by this virtual machine.  |
| [**VirtualMachineGetDeclaredAlarmState**](VirtualMachineApi.md#virtualmachinegetdeclaredalarmstate) | **GET** /VirtualMachine/{moId}/declaredAlarmState | A set of alarm states for alarms that apply to this managed entity.  |
| [**VirtualMachineGetDisabledMethod**](VirtualMachineApi.md#virtualmachinegetdisabledmethod) | **GET** /VirtualMachine/{moId}/disabledMethod | List of operations that are disabled, given the current runtime state of the entity.  |
| [**VirtualMachineGetEffectiveRole**](VirtualMachineApi.md#virtualmachinegeteffectiverole) | **GET** /VirtualMachine/{moId}/effectiveRole | Access rights the current session has to this entity.  |
| [**VirtualMachineGetEnvironmentBrowser**](VirtualMachineApi.md#virtualmachinegetenvironmentbrowser) | **GET** /VirtualMachine/{moId}/environmentBrowser | The current virtual machine&#39;s environment browser object.  |
| [**VirtualMachineGetGuest**](VirtualMachineApi.md#virtualmachinegetguest) | **GET** /VirtualMachine/{moId}/guest | Information about VMware Tools and about the virtual machine from the perspective of VMware Tools.  |
| [**VirtualMachineGetGuestHeartbeatStatus**](VirtualMachineApi.md#virtualmachinegetguestheartbeatstatus) | **GET** /VirtualMachine/{moId}/guestHeartbeatStatus | The guest heartbeat.  |
| [**VirtualMachineGetLayout**](VirtualMachineApi.md#virtualmachinegetlayout) | **GET** /VirtualMachine/{moId}/layout | Detailed information about the files that comprise this virtual machine.  |
| [**VirtualMachineGetLayoutEx**](VirtualMachineApi.md#virtualmachinegetlayoutex) | **GET** /VirtualMachine/{moId}/layoutEx | Detailed information about the files that comprise this virtual machine.  |
| [**VirtualMachineGetName**](VirtualMachineApi.md#virtualmachinegetname) | **GET** /VirtualMachine/{moId}/name | Name of this entity, unique relative to its parent.  |
| [**VirtualMachineGetNetwork**](VirtualMachineApi.md#virtualmachinegetnetwork) | **GET** /VirtualMachine/{moId}/network | A collection of references to the subset of network objects in the datacenter that is used by this virtual machine.  |
| [**VirtualMachineGetOverallStatus**](VirtualMachineApi.md#virtualmachinegetoverallstatus) | **GET** /VirtualMachine/{moId}/overallStatus | General health of this managed entity.  |
| [**VirtualMachineGetParent**](VirtualMachineApi.md#virtualmachinegetparent) | **GET** /VirtualMachine/{moId}/parent | Parent of this entity.  |
| [**VirtualMachineGetParentVApp**](VirtualMachineApi.md#virtualmachinegetparentvapp) | **GET** /VirtualMachine/{moId}/parentVApp | Reference to the parent vApp.  |
| [**VirtualMachineGetPermission**](VirtualMachineApi.md#virtualmachinegetpermission) | **GET** /VirtualMachine/{moId}/permission | List of the permissions explicitly defined for this entity.  |
| [**VirtualMachineGetRecentTask**](VirtualMachineApi.md#virtualmachinegetrecenttask) | **GET** /VirtualMachine/{moId}/recentTask | The set of recent tasks operating on this managed entity.  |
| [**VirtualMachineGetResourceConfig**](VirtualMachineApi.md#virtualmachinegetresourceconfig) | **GET** /VirtualMachine/{moId}/resourceConfig | The resource configuration for a virtual machine.  |
| [**VirtualMachineGetResourcePool**](VirtualMachineApi.md#virtualmachinegetresourcepool) | **GET** /VirtualMachine/{moId}/resourcePool | The current resource pool that specifies resource allocation for this virtual machine.  |
| [**VirtualMachineGetRootSnapshot**](VirtualMachineApi.md#virtualmachinegetrootsnapshot) | **GET** /VirtualMachine/{moId}/rootSnapshot | The roots of all snapshot trees for the virtual machine.  |
| [**VirtualMachineGetRuntime**](VirtualMachineApi.md#virtualmachinegetruntime) | **GET** /VirtualMachine/{moId}/runtime | Execution state and history for this virtual machine.  |
| [**VirtualMachineGetSnapshot**](VirtualMachineApi.md#virtualmachinegetsnapshot) | **GET** /VirtualMachine/{moId}/snapshot | Current snapshot and tree.  |
| [**VirtualMachineGetStorage**](VirtualMachineApi.md#virtualmachinegetstorage) | **GET** /VirtualMachine/{moId}/storage | Storage space used by the virtual machine, split by datastore.  |
| [**VirtualMachineGetSummary**](VirtualMachineApi.md#virtualmachinegetsummary) | **GET** /VirtualMachine/{moId}/summary | Basic information about this virtual machine.  |
| [**VirtualMachineGetTag**](VirtualMachineApi.md#virtualmachinegettag) | **GET** /VirtualMachine/{moId}/tag | The set of tags associated with this managed entity.  |
| [**VirtualMachineGetTriggeredAlarmState**](VirtualMachineApi.md#virtualmachinegettriggeredalarmstate) | **GET** /VirtualMachine/{moId}/triggeredAlarmState | A set of alarm states for alarms triggered by this entity or by its descendants.  |
| [**VirtualMachineGetValue**](VirtualMachineApi.md#virtualmachinegetvalue) | **GET** /VirtualMachine/{moId}/value | List of custom field values.  |
| [**VirtualMachineInstantCloneTask**](VirtualMachineApi.md#virtualmachineinstantclonetask) | **POST** /VirtualMachine/{moId}/InstantClone_Task | Creates a powered-on Instant Clone of a virtual machine.  |
| [**VirtualMachineMakePrimaryVMTask**](VirtualMachineApi.md#virtualmachinemakeprimaryvmtask) | **POST** /VirtualMachine/{moId}/MakePrimaryVM_Task | Makes the specified secondary virtual machine from this fault tolerant group as the primary virtual machine.  |
| [**VirtualMachineMarkAsTemplate**](VirtualMachineApi.md#virtualmachinemarkastemplate) | **POST** /VirtualMachine/{moId}/MarkAsTemplate | Marks a VirtualMachine object as being used as a template.  |
| [**VirtualMachineMarkAsVirtualMachine**](VirtualMachineApi.md#virtualmachinemarkasvirtualmachine) | **POST** /VirtualMachine/{moId}/MarkAsVirtualMachine | Clears the &#39;isTemplate&#39; flag and reassociates the virtual machine with a resource pool and host.  |
| [**VirtualMachineMigrateVMTask**](VirtualMachineApi.md#virtualmachinemigratevmtask) | **POST** /VirtualMachine/{moId}/MigrateVM_Task | Migrates a virtual machine&#39;s execution to a specific resource pool or host.  |
| [**VirtualMachineMountToolsInstaller**](VirtualMachineApi.md#virtualmachinemounttoolsinstaller) | **POST** /VirtualMachine/{moId}/MountToolsInstaller | Mounts the VMware Tools CD installer as a CD-ROM for the guest operating system.  |
| [**VirtualMachinePowerOffVMTask**](VirtualMachineApi.md#virtualmachinepoweroffvmtask) | **POST** /VirtualMachine/{moId}/PowerOffVM_Task | Powers off this virtual machine.  |
| [**VirtualMachinePowerOnVMTask**](VirtualMachineApi.md#virtualmachinepoweronvmtask) | **POST** /VirtualMachine/{moId}/PowerOnVM_Task | Powers on this virtual machine.  |
| [**VirtualMachinePromoteDisksTask**](VirtualMachineApi.md#virtualmachinepromotediskstask) | **POST** /VirtualMachine/{moId}/PromoteDisks_Task | Promotes disks on this virtual machine that have delta disk backings.  |
| [**VirtualMachinePutUsbScanCodes**](VirtualMachineApi.md#virtualmachineputusbscancodes) | **POST** /VirtualMachine/{moId}/PutUsbScanCodes | Inject a sequence of USB HID scan codes into the keyboard.  |
| [**VirtualMachineQueryChangedDiskAreas**](VirtualMachineApi.md#virtualmachinequerychangeddiskareas) | **POST** /VirtualMachine/{moId}/QueryChangedDiskAreas | Get a list of areas of a virtual disk belonging to this VM that have been modified since a well-defined point in the past.  |
| [**VirtualMachineQueryConnections**](VirtualMachineApi.md#virtualmachinequeryconnections) | **POST** /VirtualMachine/{moId}/QueryConnections | Ask the virtual machine for a list of connections.  |
| [**VirtualMachineQueryFaultToleranceCompatibility**](VirtualMachineApi.md#virtualmachinequeryfaulttolerancecompatibility) | **POST** /VirtualMachine/{moId}/QueryFaultToleranceCompatibility | This API can be invoked to determine whether a virtual machine is compatible for legacy Fault Tolerance.  |
| [**VirtualMachineQueryFaultToleranceCompatibilityEx**](VirtualMachineApi.md#virtualmachinequeryfaulttolerancecompatibilityex) | **POST** /VirtualMachine/{moId}/QueryFaultToleranceCompatibilityEx | This API can be invoked to determine whether a virtual machine is compatible for Fault Tolerance.  |
| [**VirtualMachineQueryUnownedFiles**](VirtualMachineApi.md#virtualmachinequeryunownedfiles) | **POST** /VirtualMachine/{moId}/QueryUnownedFiles | For all files that belong to the vm, check that the file owner is set to the current datastore principal user, as set by *HostDatastoreSystem.ConfigureDatastorePrincipal*  |
| [**VirtualMachineRebootGuest**](VirtualMachineApi.md#virtualmachinerebootguest) | **POST** /VirtualMachine/{moId}/RebootGuest | Issues a command to the guest operating system asking it to perform a reboot.  |
| [**VirtualMachineReconfigVMTask**](VirtualMachineApi.md#virtualmachinereconfigvmtask) | **POST** /VirtualMachine/{moId}/ReconfigVM_Task | Reconfigures this virtual machine.  |
| [**VirtualMachineRefreshStorageInfo**](VirtualMachineApi.md#virtualmachinerefreshstorageinfo) | **POST** /VirtualMachine/{moId}/RefreshStorageInfo | Explicitly refreshes the storage information of this virtual machine, updating properties *VirtualMachine.storage*, *VirtualMachine.layoutEx* and *VirtualMachineSummary.storage*.  |
| [**VirtualMachineReload**](VirtualMachineApi.md#virtualmachinereload) | **POST** /VirtualMachine/{moId}/Reload | Reload the entity state.  |
| [**VirtualMachineReloadVirtualMachineFromPathTask**](VirtualMachineApi.md#virtualmachinereloadvirtualmachinefrompathtask) | **POST** /VirtualMachine/{moId}/reloadVirtualMachineFromPath_Task | Reloads the configuration for this virtual machine from a given datastore path.  |
| [**VirtualMachineRelocateVMTask**](VirtualMachineApi.md#virtualmachinerelocatevmtask) | **POST** /VirtualMachine/{moId}/RelocateVM_Task | Relocates a virtual machine to the location specified by *VirtualMachineRelocateSpec*.  |
| [**VirtualMachineRemoveAllSnapshotsTask**](VirtualMachineApi.md#virtualmachineremoveallsnapshotstask) | **POST** /VirtualMachine/{moId}/RemoveAllSnapshots_Task | Remove all the snapshots associated with this virtual machine.  |
| [**VirtualMachineRenameTask**](VirtualMachineApi.md#virtualmachinerenametask) | **POST** /VirtualMachine/{moId}/Rename_Task | Renames this managed entity.  |
| [**VirtualMachineRepairVmDiskChainsTask**](VirtualMachineApi.md#virtualmachinerepairvmdiskchainstask) | **POST** /VirtualMachine/{moId}/RepairVmDiskChains_Task | Repair the broken disk chains in the VM while the VM is powered off.  |
| [**VirtualMachineResetGuestInformation**](VirtualMachineApi.md#virtualmachineresetguestinformation) | **POST** /VirtualMachine/{moId}/ResetGuestInformation | Clears cached guest information.  |
| [**VirtualMachineResetVMTask**](VirtualMachineApi.md#virtualmachineresetvmtask) | **POST** /VirtualMachine/{moId}/ResetVM_Task | Resets power on this virtual machine.  |
| [**VirtualMachineRevertToCurrentSnapshotTask**](VirtualMachineApi.md#virtualmachinereverttocurrentsnapshottask) | **POST** /VirtualMachine/{moId}/RevertToCurrentSnapshot_Task | Reverts the virtual machine to the current snapshot.  |
| [**VirtualMachineSendNMI**](VirtualMachineApi.md#virtualmachinesendnmi) | **POST** /VirtualMachine/{moId}/SendNMI | Send a non-maskable interrupt (NMI).  |
| [**VirtualMachineSetCustomValue**](VirtualMachineApi.md#virtualmachinesetcustomvalue) | **POST** /VirtualMachine/{moId}/setCustomValue | Assigns a value to a custom field.  |
| [**VirtualMachineSetDisplayTopology**](VirtualMachineApi.md#virtualmachinesetdisplaytopology) | **POST** /VirtualMachine/{moId}/SetDisplayTopology | Sets the console window&#39;s display topology as specified.  |
| [**VirtualMachineSetScreenResolution**](VirtualMachineApi.md#virtualmachinesetscreenresolution) | **POST** /VirtualMachine/{moId}/SetScreenResolution | Sets the console window&#39;s resolution as specified.  |
| [**VirtualMachineShutdownGuest**](VirtualMachineApi.md#virtualmachineshutdownguest) | **POST** /VirtualMachine/{moId}/ShutdownGuest | Issues a command to the guest operating system asking it to perform a clean shutdown of all services.  |
| [**VirtualMachineStandbyGuest**](VirtualMachineApi.md#virtualmachinestandbyguest) | **POST** /VirtualMachine/{moId}/StandbyGuest | Issues a command to the guest operating system asking it to prepare for a suspend operation.  |
| [**VirtualMachineStartRecordingTask**](VirtualMachineApi.md#virtualmachinestartrecordingtask) | **POST** /VirtualMachine/{moId}/StartRecording_Task | Initiates a recording session on this virtual machine.  |
| [**VirtualMachineStartReplayingTask**](VirtualMachineApi.md#virtualmachinestartreplayingtask) | **POST** /VirtualMachine/{moId}/StartReplaying_Task | Starts a replay session on this virtual machine.  |
| [**VirtualMachineStopRecordingTask**](VirtualMachineApi.md#virtualmachinestoprecordingtask) | **POST** /VirtualMachine/{moId}/StopRecording_Task | Stops a currently active recording session on this virtual machine.  |
| [**VirtualMachineStopReplayingTask**](VirtualMachineApi.md#virtualmachinestopreplayingtask) | **POST** /VirtualMachine/{moId}/StopReplaying_Task | Stops a replay session on this virtual machine.  |
| [**VirtualMachineSuspendVMTask**](VirtualMachineApi.md#virtualmachinesuspendvmtask) | **POST** /VirtualMachine/{moId}/SuspendVM_Task | Suspends execution in this virtual machine.  |
| [**VirtualMachineTerminateFaultTolerantVMTask**](VirtualMachineApi.md#virtualmachineterminatefaulttolerantvmtask) | **POST** /VirtualMachine/{moId}/TerminateFaultTolerantVM_Task | Terminates the specified secondary virtual machine in a fault tolerant group.  |
| [**VirtualMachineTerminateVM**](VirtualMachineApi.md#virtualmachineterminatevm) | **POST** /VirtualMachine/{moId}/TerminateVM | Do an immediate power off of a VM.  |
| [**VirtualMachineTurnOffFaultToleranceForVMTask**](VirtualMachineApi.md#virtualmachineturnofffaulttoleranceforvmtask) | **POST** /VirtualMachine/{moId}/TurnOffFaultToleranceForVM_Task | Removes all secondary virtual machines associated with the fault tolerant group and turns off protection for this virtual machine.  |
| [**VirtualMachineUnmountToolsInstaller**](VirtualMachineApi.md#virtualmachineunmounttoolsinstaller) | **POST** /VirtualMachine/{moId}/UnmountToolsInstaller | Unmounts VMware Tools installer CD.  |
| [**VirtualMachineUnregisterVM**](VirtualMachineApi.md#virtualmachineunregistervm) | **POST** /VirtualMachine/{moId}/UnregisterVM | Removes this virtual machine from the inventory without removing any of the virtual machine&#39;s files on disk.  |
| [**VirtualMachineUpgradeToolsTask**](VirtualMachineApi.md#virtualmachineupgradetoolstask) | **POST** /VirtualMachine/{moId}/UpgradeTools_Task | Begins the tools upgrade process.  |
| [**VirtualMachineUpgradeVMTask**](VirtualMachineApi.md#virtualmachineupgradevmtask) | **POST** /VirtualMachine/{moId}/UpgradeVM_Task | Upgrades this virtual machine&#39;s virtual hardware to the latest revision that is supported by the virtual machine&#39;s current host.  |

<a id="virtualmachineacquiremksticket"></a>
# **VirtualMachineAcquireMksTicket**
> VirtualMachineMksTicket VirtualMachineAcquireMksTicket (string moId)

Creates and returns a one-time credential used in establishing a remote mouse-keyboard-screen connection to this virtual machine. 

Deprecated as of vSphere API 4.1, use *VirtualMachine.AcquireTicket* instead.  Creates and returns a one-time credential used in establishing a remote mouse-keyboard-screen connection to this virtual machine.  The correct function of this method depends on being able to retrieve TCP binding information about the server end of the client connection that is requesting the ticket. If such information is not available, the NotSupported fault is thrown. This method is appropriate for SOAP and authenticated connections, which are both TCP-based connections.  ***Required privileges:*** VirtualMachine.Interact.ConsoleInteract 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineAcquireMksTicketExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Creates and returns a one-time credential used in establishing a remote mouse-keyboard-screen connection to this virtual machine. 
                VirtualMachineMksTicket result = apiInstance.VirtualMachineAcquireMksTicket(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineAcquireMksTicket: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineAcquireMksTicketWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates and returns a one-time credential used in establishing a remote mouse-keyboard-screen connection to this virtual machine. 
    ApiResponse<VirtualMachineMksTicket> response = apiInstance.VirtualMachineAcquireMksTicketWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineAcquireMksTicketWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**VirtualMachineMksTicket**](VirtualMachineMksTicket.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A one-time credential used in establishing a remote mouse-keyboard-screen connection.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachineacquireticket"></a>
# **VirtualMachineAcquireTicket**
> VirtualMachineTicket VirtualMachineAcquireTicket (string moId, AcquireTicketRequestType acquireTicketRequestType)

Creates and returns a one-time credential used in establishing a specific connection to this virtual machine, for example, a ticket type of mks can be used to establish a remote mouse-keyboard-screen connection. 

Creates and returns a one-time credential used in establishing a specific connection to this virtual machine, for example, a ticket type of mks can be used to establish a remote mouse-keyboard-screen connection.  A client using this ticketing mechanism must have network connectivity to the ESX server where the virtual machine is running, and the ESX server must be reachable to the management client from the address made available to the client via the ticket.  Acquiring a virtual machine ticket requires different privileges depending on the types of ticket: - VirtualMachine.Interact.DeviceConnection if requesting a device   ticket. - VirtualMachine.Interact.GuestControl if requesting a guestControl   or guestIntegrity ticket. - VirtualMachine.Interact.ConsoleInteract if requesting an mks   or webmks ticket. - VirtualMachine.Interact.DnD if requesting a drag and drop   ticket. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineAcquireTicketExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var acquireTicketRequestType = new AcquireTicketRequestType(); // AcquireTicketRequestType | 

            try
            {
                // Creates and returns a one-time credential used in establishing a specific connection to this virtual machine, for example, a ticket type of mks can be used to establish a remote mouse-keyboard-screen connection. 
                VirtualMachineTicket result = apiInstance.VirtualMachineAcquireTicket(moId, acquireTicketRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineAcquireTicket: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineAcquireTicketWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates and returns a one-time credential used in establishing a specific connection to this virtual machine, for example, a ticket type of mks can be used to establish a remote mouse-keyboard-screen connection. 
    ApiResponse<VirtualMachineTicket> response = apiInstance.VirtualMachineAcquireTicketWithHttpInfo(moId, acquireTicketRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineAcquireTicketWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **acquireTicketRequestType** | [**AcquireTicketRequestType**](AcquireTicketRequestType.md) |  |  |

### Return type

[**VirtualMachineTicket**](VirtualMachineTicket.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A one-time credential used in establishing a remote connection to this virtual machine.  |  -  |
| **500** | ***InvalidState***: if the virtual machine is not connected.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachineanswervm"></a>
# **VirtualMachineAnswerVM**
> void VirtualMachineAnswerVM (string moId, AnswerVMRequestType answerVMRequestType)

Responds to a question that is blocking this virtual machine. 

Responds to a question that is blocking this virtual machine.  ***Required privileges:*** VirtualMachine.Interact.AnswerQuestion 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineAnswerVMExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var answerVMRequestType = new AnswerVMRequestType(); // AnswerVMRequestType | 

            try
            {
                // Responds to a question that is blocking this virtual machine. 
                apiInstance.VirtualMachineAnswerVM(moId, answerVMRequestType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineAnswerVM: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineAnswerVMWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Responds to a question that is blocking this virtual machine. 
    apiInstance.VirtualMachineAnswerVMWithHttpInfo(moId, answerVMRequestType);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineAnswerVMWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **answerVMRequestType** | [**AnswerVMRequestType**](AnswerVMRequestType.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content  |  -  |
| **500** | ***InvalidArgument***: if the questionId does not apply to this virtual machine. For example, this can happen if another client already answered the message.  ***ConcurrentAccess***: if the question has been or is being answered by another thread or user.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachineapplyevcmodevmtask"></a>
# **VirtualMachineApplyEvcModeVMTask**
> ManagedObjectReference VirtualMachineApplyEvcModeVMTask (string moId, ApplyEvcModeVMRequestType? applyEvcModeVMRequestType = null)

Applies the EVC mode masks to the virtual machine. 

Applies the EVC mode masks to the virtual machine.  Existing masks will be replaced by the input masks. If the mask parameter is not set, then the masks on the virtual machine are removed. See *EVCMode.featureMask* for the list of masks to provide. These can be retrieved from *Capability.supportedEVCMode*, which is accessible in *ServiceInstance.capability*.  This operation is only supported if *VirtualMachineCapability.perVmEvcSupported* is true.  ***Required privileges:*** VirtualMachine.Config.Settings 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineApplyEvcModeVMTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var applyEvcModeVMRequestType = new ApplyEvcModeVMRequestType?(); // ApplyEvcModeVMRequestType? |  (optional) 

            try
            {
                // Applies the EVC mode masks to the virtual machine. 
                ManagedObjectReference result = apiInstance.VirtualMachineApplyEvcModeVMTask(moId, applyEvcModeVMRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineApplyEvcModeVMTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineApplyEvcModeVMTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Applies the EVC mode masks to the virtual machine. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineApplyEvcModeVMTaskWithHttpInfo(moId, applyEvcModeVMRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineApplyEvcModeVMTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **applyEvcModeVMRequestType** | [**ApplyEvcModeVMRequestType?**](ApplyEvcModeVMRequestType?.md) |  | [optional]  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Refers instance of *Task*.  |  -  |
| **500** | ***InvalidPowerState***: if the power state is not poweredOff.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachineattachdisktask"></a>
# **VirtualMachineAttachDiskTask**
> ManagedObjectReference VirtualMachineAttachDiskTask (string moId, AttachDiskRequestType attachDiskRequestType)

Attach an existing disk to this virtual machine. 

Attach an existing disk to this virtual machine.  A minimum virtual machine version of 'vmx-13' is required for this operation to succeed. If a compatible VM version is not satisfied, a *DeviceUnsupportedForVmVersion* fault will be thrown.  ***Required privileges:*** VirtualMachine.Config.AddExistingDisk 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineAttachDiskTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var attachDiskRequestType = new AttachDiskRequestType(); // AttachDiskRequestType | 

            try
            {
                // Attach an existing disk to this virtual machine. 
                ManagedObjectReference result = apiInstance.VirtualMachineAttachDiskTask(moId, attachDiskRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineAttachDiskTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineAttachDiskTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Attach an existing disk to this virtual machine. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineAttachDiskTaskWithHttpInfo(moId, attachDiskRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineAttachDiskTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **attachDiskRequestType** | [**AttachDiskRequestType**](AttachDiskRequestType.md) |  |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Refers instance of *Task*.  |  -  |
| **500** | ***NotFound***: if the disk object cannot be found.  ***VmConfigFault***: if the virtual machine&#39;s configuration is invalid.  ***FileFault***: if there is a problem creating or accessing the virtual machine&#39;s files for this operation.  ***InvalidState***: if the operation cannot be performed in the current state of the virtual machine. For example, because the virtual machine&#39;s configuration is not available.  ***InvalidDatastore***: If the datastore cannot be found or inaccessible.  ***InvalidController***: If the specified controller cannot be found or the specified unitNumber is already taken, or the controller has no free slots.  ***MissingController***: If the virtual machine has no or more than one available controllers when controllerKey is unset.  ***DeviceUnsupportedForVmVersion***: If the virtual machine&#39;s version is incompatible for the given device.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinecheckcustomizationspec"></a>
# **VirtualMachineCheckCustomizationSpec**
> void VirtualMachineCheckCustomizationSpec (string moId, CheckCustomizationSpecRequestType checkCustomizationSpecRequestType)

Checks the customization specification against the virtual machine configuration. 

Checks the customization specification against the virtual machine configuration.  For example, this is used on a source virtual machine before a clone operation to catch customization failure before the disk copy. This checks the specification's internal consistency as well as for compatibility with this virtual machine's configuration.  ***Required privileges:*** VirtualMachine.Provisioning.Customize 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineCheckCustomizationSpecExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var checkCustomizationSpecRequestType = new CheckCustomizationSpecRequestType(); // CheckCustomizationSpecRequestType | 

            try
            {
                // Checks the customization specification against the virtual machine configuration. 
                apiInstance.VirtualMachineCheckCustomizationSpec(moId, checkCustomizationSpecRequestType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineCheckCustomizationSpec: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineCheckCustomizationSpecWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Checks the customization specification against the virtual machine configuration. 
    apiInstance.VirtualMachineCheckCustomizationSpecWithHttpInfo(moId, checkCustomizationSpecRequestType);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineCheckCustomizationSpecWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **checkCustomizationSpecRequestType** | [**CheckCustomizationSpecRequestType**](CheckCustomizationSpecRequestType.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content  |  -  |
| **500** | ***CustomizationFault***: A subclass of CustomizationFault is thrown.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachineclonevmtask"></a>
# **VirtualMachineCloneVMTask**
> ManagedObjectReference VirtualMachineCloneVMTask (string moId, CloneVMRequestType cloneVMRequestType)

Creates a clone of this virtual machine. 

Creates a clone of this virtual machine.  If the virtual machine is used as a template, this method corresponds to the deploy command.  Any % (percent) character used in this name parameter must be escaped, unless it is used to start an escape sequence. Clients may also escape any other characters in this name parameter.  The privilege required on the source virtual machine depends on the source and destination types: - source is virtual machine, destination is virtual machine -   VirtualMachine.Provisioning.Clone - source is virtual machine, destination is template -   VirtualMachine.Provisioning.CreateTemplateFromVM - source is template, destination is virtual machine -   VirtualMachine.Provisioning.DeployTemplate - source is template, destination is template -   VirtualMachine.Provisioning.CloneTemplate - source is encrypted virtual machine -   Cryptographer.Clone and starting from vSphere 9.0   Cryptographer.Access is also required    If customization is requested in the CloneSpec, then the VirtualMachine.Provisioning.Customize privilege must also be held on the source virtual machine.  The VirtualMachine.Inventory.CreateFromExisting privilege is required on the destination folder.  The Resource.AssignVMToPool privilege is also required for the resource pool specified in the CloneSpec, if the destination is not a template. The Datastore.AllocateSpace privilege is required on all datastores where the clone is created. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineCloneVMTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var cloneVMRequestType = new CloneVMRequestType(); // CloneVMRequestType | 

            try
            {
                // Creates a clone of this virtual machine. 
                ManagedObjectReference result = apiInstance.VirtualMachineCloneVMTask(moId, cloneVMRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineCloneVMTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineCloneVMTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a clone of this virtual machine. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineCloneVMTaskWithHttpInfo(moId, cloneVMRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineCloneVMTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **cloneVMRequestType** | [**CloneVMRequestType**](CloneVMRequestType.md) |  |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation. The *info.result* property in the *Task* contains the newly added *VirtualMachine* upon success.  Refers instance of *Task*.  |  -  |
| **500** | ***InvalidArgument***: if the host cannot run this virtual machine.  ***CustomizationFault***: if a customization error happens. Typically, a specific subclass of this exception is thrown.  ***TaskInProgress***: if the virtual machine is busy.  ***NotSupported***: if the operation is not supported by the current agent.  ***InvalidState***: if the operation cannot be performed because of the virtual machine&#39;s current state. For example, if the virtual machine configuration information is not available.  ***InvalidDatastore***: if the operation cannot be performed on the target datastores.  ***FileFault***: if there is an error accessing the virtual machine files.  ***VmConfigFault***: if the virtual machine is not compatible with the destination host. Typically, a specific subclass of this exception is thrown, such as IDEDiskNotSupported.  ***MigrationFault***: if it is not possible to migrate the virtual machine to the destination host. This is typically due to hosts being incompatible, such as mismatch in network polices or access to networks and datastores. Typically, a more specific subclass is thrown.  ***InsufficientResourcesFault***: if this operation would violate a resource usage policy.  ***NoPermission***: if the virtual machine is encrypted, but encryption is not enabled on the destination and the user does not have Cryptographer.RegisterHost permission on the host.  ***NoPermission***: if source virtual machine is encrypted, but the user does not have Cryptographer.Clone permission on it.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachineconsolidatevmdiskstask"></a>
# **VirtualMachineConsolidateVMDisksTask**
> ManagedObjectReference VirtualMachineConsolidateVMDisksTask (string moId)

Consolidate the virtual disk files of the virtual machine by finding hierarchies of redo logs that can be combined without violating data dependency. 

Consolidate the virtual disk files of the virtual machine by finding hierarchies of redo logs that can be combined without violating data dependency.  The redundant redo logs after merging are then deleted. Consolidation improves I/O performance since less number of virtual disk files need to be traversed; it also reduces the storage usage. However additional space is temporarily required to perform the operation. Use *VirtualMachine.EstimateStorageForConsolidateSnapshots_Task* to estimate the temporary space required. Consolidation can be I/O intensive, it is advisable to invoke this operation when guest is not under heavy I/O usage.  ***Required privileges:*** VirtualMachine.State.RemoveSnapshot 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineConsolidateVMDisksTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Consolidate the virtual disk files of the virtual machine by finding hierarchies of redo logs that can be combined without violating data dependency. 
                ManagedObjectReference result = apiInstance.VirtualMachineConsolidateVMDisksTask(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineConsolidateVMDisksTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineConsolidateVMDisksTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Consolidate the virtual disk files of the virtual machine by finding hierarchies of redo logs that can be combined without violating data dependency. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineConsolidateVMDisksTaskWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineConsolidateVMDisksTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation.  Refers instance of *Task*.  |  -  |
| **500** | ***TaskInProgress***: if the virtual machine is busy.  ***FileFault***: if if there is a problem creating or accessing the virtual machine&#39;s files for this operation. Typically a more specific fault for example *NoDiskSpace* is thrown.  ***InvalidState***: if the operation cannot be performed because of the virtual machine&#39;s current state. For example, if the virtual machine configuration information is not available.  ***VmConfigFault***: if a virtual machine configuration issue prevents consolidation. Typically, a more specific fault is thrown such as *InvalidDiskFormat* if a disk cannot be read, or *InvalidSnapshotFormat* if the snapshot configuration is invalid.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinecreatescreenshottask"></a>
# **VirtualMachineCreateScreenshotTask**
> ManagedObjectReference VirtualMachineCreateScreenshotTask (string moId)

Create a screen shot of a virtual machine. 

Create a screen shot of a virtual machine.  ***Required privileges:*** VirtualMachine.Interact.CreateScreenshot 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineCreateScreenshotTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Create a screen shot of a virtual machine. 
                ManagedObjectReference result = apiInstance.VirtualMachineCreateScreenshotTask(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineCreateScreenshotTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineCreateScreenshotTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a screen shot of a virtual machine. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineCreateScreenshotTaskWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineCreateScreenshotTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Refers instance of *Task*.  |  -  |
| **500** | ***TaskInProgress***: if the virtual machine is busy.  ***FileFault***: if there is a problem with creating or accessing one or more files needed for this operation.  ***InvalidPowerState***: if the virtual machine is not powered on.  ***InvalidState***: if the virtual machine is not ready to respond to such requests.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinecreatesecondaryvmextask"></a>
# **VirtualMachineCreateSecondaryVMExTask**
> ManagedObjectReference VirtualMachineCreateSecondaryVMExTask (string moId, CreateSecondaryVMExRequestType? createSecondaryVMExRequestType = null)

Creates a secondary virtual machine to be part of this fault tolerant group. 

Creates a secondary virtual machine to be part of this fault tolerant group.  If a host is specified, the secondary virtual machine will be created on it. Otherwise, a host will be selected by the system.  If a FaultToleranceConfigSpec is specified, the virtual machine's configuration files and disks will be created in the specified datastores.  If the primary virtual machine (i.e., this virtual machine) is powered on when the secondary is created, an attempt will be made to power on the secondary on a system selected host. If the cluster is a DRS cluster, DRS will be invoked to obtain a placement for the new secondary virtual machine. If the DRS recommendation (see *ClusterRecommendation*) is automatic, it will be automatically executed. Otherwise, the recommendation will be returned to the caller of this method and the secondary will remain powered off until the recommendation is approved using *ClusterComputeResource.ApplyRecommendation*. Failure to power on the secondary virtual machine will not fail the creation of the secondary.  ***Required privileges:*** VirtualMachine.Interact.CreateSecondary 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineCreateSecondaryVMExTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var createSecondaryVMExRequestType = new CreateSecondaryVMExRequestType?(); // CreateSecondaryVMExRequestType? |  (optional) 

            try
            {
                // Creates a secondary virtual machine to be part of this fault tolerant group. 
                ManagedObjectReference result = apiInstance.VirtualMachineCreateSecondaryVMExTask(moId, createSecondaryVMExRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineCreateSecondaryVMExTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineCreateSecondaryVMExTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a secondary virtual machine to be part of this fault tolerant group. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineCreateSecondaryVMExTaskWithHttpInfo(moId, createSecondaryVMExRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineCreateSecondaryVMExTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **createSecondaryVMExRequestType** | [**CreateSecondaryVMExRequestType?**](CreateSecondaryVMExRequestType?.md) |  | [optional]  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation. The *info.result* property in the *Task* returns an instance of the *FaultToleranceSecondaryOpResult* data object, which contains a reference to the created *VirtualMachine* and the status of powering it on, if attempted.  Refers instance of *Task*.  |  -  |
| **500** | ***TaskInProgress***: if the virtual machine is busy.  ***NotSupported***: if the virtual machine is marked as a template, or it is not in a vSphere HA enabled cluster.  ***InvalidState***: if the virtual machine&#39;s configuration information is not available.  ***ManagedObjectNotFound***: if a host is specified and it does not exist.  ***InsufficientResourcesFault***: if this operation would violate a resource usage policy.  ***VmFaultToleranceIssue***: if any error is encountered with the fault tolerance configuration of the virtual machine. Typically, a more specific fault like FaultToleranceNotLicensed is thrown.  ***FileFault***: if there is a problem accessing the virtual machine on the filesystem.  ***VmConfigFault***: if a configuration issue prevents creating the secondary. Typically, a more specific fault such as VmConfigIncompatibleForFaultTolerance is thrown.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinecreatesecondaryvmtask"></a>
# **VirtualMachineCreateSecondaryVMTask**
> ManagedObjectReference VirtualMachineCreateSecondaryVMTask (string moId, CreateSecondaryVMRequestType? createSecondaryVMRequestType = null)

Creates a secondary virtual machine to be part of this fault tolerant group. 

Deprecated as of vSphere API 6.0, use *VirtualMachine.CreateSecondaryVMEx_Task* instead.  Creates a secondary virtual machine to be part of this fault tolerant group.  If a host is specified, the secondary virtual machine will be created on it. Otherwise, a host will be selected by the system.  If the primary virtual machine (i.e., this virtual machine) is powered on when the secondary is created, an attempt will be made to power on the secondary on a system selected host. If the cluster is a DRS cluster, DRS will be invoked to obtain a placement for the new secondary virtual machine. If the DRS recommendation (see *ClusterRecommendation*) is automatic, it will be automatically executed. Otherwise, the recommendation will be returned to the caller of this method and the secondary will remain powered off until the recommendation is approved using *ClusterComputeResource.ApplyRecommendation*. Failure to power on the secondary virtual machine will not fail the creation of the secondary.  ***Required privileges:*** VirtualMachine.Interact.CreateSecondary 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineCreateSecondaryVMTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var createSecondaryVMRequestType = new CreateSecondaryVMRequestType?(); // CreateSecondaryVMRequestType? |  (optional) 

            try
            {
                // Creates a secondary virtual machine to be part of this fault tolerant group. 
                ManagedObjectReference result = apiInstance.VirtualMachineCreateSecondaryVMTask(moId, createSecondaryVMRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineCreateSecondaryVMTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineCreateSecondaryVMTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a secondary virtual machine to be part of this fault tolerant group. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineCreateSecondaryVMTaskWithHttpInfo(moId, createSecondaryVMRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineCreateSecondaryVMTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **createSecondaryVMRequestType** | [**CreateSecondaryVMRequestType?**](CreateSecondaryVMRequestType?.md) |  | [optional]  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation. The *info.result* property in the *Task* returns an instance of the *FaultToleranceSecondaryOpResult* data object, which contains a reference to the created *VirtualMachine* and the status of powering it on, if attempted.  Refers instance of *Task*.  |  -  |
| **500** | ***TaskInProgress***: if the virtual machine is busy.  ***NotSupported***: if the virtual machine is marked as a template, or it is not in a vSphere HA enabled cluster.  ***InvalidState***: if the virtual machine&#39;s configuration information is not available.  ***ManagedObjectNotFound***: if a host is specified and it does not exist.  ***InsufficientResourcesFault***: if this operation would violate a resource usage policy.  ***VmFaultToleranceIssue***: if any error is encountered with the fault tolerance configuration of the virtual machine. Typically, a more specific fault like FaultToleranceNotLicensed is thrown.  ***FileFault***: if there is a problem accessing the virtual machine on the filesystem.  ***VmConfigFault***: if a configuration issue prevents creating the secondary. Typically, a more specific fault such as VmConfigIncompatibleForFaultTolerance is thrown.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinecreatesnapshotextask"></a>
# **VirtualMachineCreateSnapshotExTask**
> ManagedObjectReference VirtualMachineCreateSnapshotExTask (string moId, CreateSnapshotExRequestType createSnapshotExRequestType)

Creates a new snapshot of this virtual machine. 

Creates a new snapshot of this virtual machine.  As a side effect, this updates the current snapshot.  Snapshots are not supported for Fault Tolerance primary and secondary virtual machines.  Any % (percent) character used in this name parameter must be escaped, unless it is used to start an escape sequence. Clients may also escape any other characters in this name parameter.  ***Required privileges:*** VirtualMachine.State.CreateSnapshot 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineCreateSnapshotExTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var createSnapshotExRequestType = new CreateSnapshotExRequestType(); // CreateSnapshotExRequestType | 

            try
            {
                // Creates a new snapshot of this virtual machine. 
                ManagedObjectReference result = apiInstance.VirtualMachineCreateSnapshotExTask(moId, createSnapshotExRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineCreateSnapshotExTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineCreateSnapshotExTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new snapshot of this virtual machine. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineCreateSnapshotExTaskWithHttpInfo(moId, createSnapshotExRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineCreateSnapshotExTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **createSnapshotExRequestType** | [**CreateSnapshotExRequestType**](CreateSnapshotExRequestType.md) |  |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation. The *info.result* property in the *Task* contains the newly created *VirtualMachineSnapshot* upon success.  Refers instance of *Task*.  |  -  |
| **500** | ***InvalidArgument***: if quiesceSpec is invalid.  ***TaskInProgress***: if the virtual machine is busy.  ***NotSupported***: if the host product does not support snapshots or if the host does not support quiesced snapshots and the quiesce spec is set; or if the virtual machine is a Fault Tolerance primary or secondary; or if an unsupported quiesce spec is set.  ***SnapshotFault***: if an error occurs during the snapshot operation. Typically a more specific fault like MultipleSnapshotsNotSupported is thrown.  ***FileFault***: if there is a problem with creating or accessing one or more files needed for this operation.  ***VmConfigFault***: if the virtual machine&#39;s configuration is invalid. Typically, a more specific fault like InvalidSnapshotState is thrown.  ***InvalidName***: if the specified snapshot name is invalid.  ***InvalidPowerState***: if the operation cannot be performed in the current power state of the virtual machine.  ***InvalidState***: if the operation cannot be performed because of the virtual machine&#39;s current state. For example, the virtual machine configuration information is not available.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinecreatesnapshottask"></a>
# **VirtualMachineCreateSnapshotTask**
> ManagedObjectReference VirtualMachineCreateSnapshotTask (string moId, CreateSnapshotRequestType createSnapshotRequestType)

Creates a new snapshot of this virtual machine. 

Deprecated as of vSphere 8.0GA, this method is deprecated. Please use *VirtualMachine.CreateSnapshotEx_Task* instead.  Creates a new snapshot of this virtual machine.  As a side effect, this updates the current snapshot.  Snapshots are not supported for Fault Tolerance primary and secondary virtual machines.  Any % (percent) character used in this name parameter must be escaped, unless it is used to start an escape sequence. Clients may also escape any other characters in this name parameter.  ***Required privileges:*** VirtualMachine.State.CreateSnapshot 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineCreateSnapshotTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var createSnapshotRequestType = new CreateSnapshotRequestType(); // CreateSnapshotRequestType | 

            try
            {
                // Creates a new snapshot of this virtual machine. 
                ManagedObjectReference result = apiInstance.VirtualMachineCreateSnapshotTask(moId, createSnapshotRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineCreateSnapshotTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineCreateSnapshotTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new snapshot of this virtual machine. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineCreateSnapshotTaskWithHttpInfo(moId, createSnapshotRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineCreateSnapshotTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **createSnapshotRequestType** | [**CreateSnapshotRequestType**](CreateSnapshotRequestType.md) |  |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation. The *info.result* property in the *Task* contains the newly created *VirtualMachineSnapshot* upon success.  Refers instance of *Task*.  |  -  |
| **500** | ***TaskInProgress***: if the virtual machine is busy.  ***NotSupported***: if the host product does not support snapshots or if the host does not support quiesced snapshots and the quiesce parameter is set to true; or if the virtual machine is a Fault Tolerance primary or secondary  ***SnapshotFault***: if an error occurs during the snapshot operation. Typically a more specific fault like MultipleSnapshotsNotSupported is thrown.  ***FileFault***: if there is a problem with creating or accessing one or more files needed for this operation.  ***VmConfigFault***: if the virtual machine&#39;s configuration is invalid. Typically, a more specific fault like InvalidSnapshotState is thrown.  ***InvalidName***: if the specified snapshot name is invalid.  ***InvalidPowerState***: if the operation cannot be performed in the current power state of the virtual machine.  ***InvalidState***: if the operation cannot be performed because of the virtual machine&#39;s current state. For example, the virtual machine configuration information is not available.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinecryptounlocktask"></a>
# **VirtualMachineCryptoUnlockTask**
> ManagedObjectReference VirtualMachineCryptoUnlockTask (string moId)

Unlocks an encrypted virtual machine by sending the encryption keys for the Virtual Machine Home and all the Virtual Disks to the ESX Server. 

Unlocks an encrypted virtual machine by sending the encryption keys for the Virtual Machine Home and all the Virtual Disks to the ESX Server.  ***Required privileges:*** Cryptographer.RegisterVM 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineCryptoUnlockTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Unlocks an encrypted virtual machine by sending the encryption keys for the Virtual Machine Home and all the Virtual Disks to the ESX Server. 
                ManagedObjectReference result = apiInstance.VirtualMachineCryptoUnlockTask(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineCryptoUnlockTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineCryptoUnlockTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unlocks an encrypted virtual machine by sending the encryption keys for the Virtual Machine Home and all the Virtual Disks to the ESX Server. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineCryptoUnlockTaskWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineCryptoUnlockTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Refers instance of *Task*.  |  -  |
| **500** | ***InvalidState***: when the required Key Management Server is not configured.  ***InvalidVmState***: when the virtual machine failed to unlock.  ***NotSupported***: if the ESX server doesn&#39;t support encryption.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinecustomizevmtask"></a>
# **VirtualMachineCustomizeVMTask**
> ManagedObjectReference VirtualMachineCustomizeVMTask (string moId, CustomizeVMRequestType customizeVMRequestType)

Customizes a virtual machine's guest operating system. 

Customizes a virtual machine's guest operating system.  ***Required privileges:*** VirtualMachine.Provisioning.Customize 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineCustomizeVMTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var customizeVMRequestType = new CustomizeVMRequestType(); // CustomizeVMRequestType | 

            try
            {
                // Customizes a virtual machine's guest operating system. 
                ManagedObjectReference result = apiInstance.VirtualMachineCustomizeVMTask(moId, customizeVMRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineCustomizeVMTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineCustomizeVMTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Customizes a virtual machine's guest operating system. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineCustomizeVMTaskWithHttpInfo(moId, customizeVMRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineCustomizeVMTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **customizeVMRequestType** | [**CustomizeVMRequestType**](CustomizeVMRequestType.md) |  |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation.  Refers instance of *Task*.  |  -  |
| **500** | ***CustomizationFault***: A subclass of CustomizationFault is thrown.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinedefragmentalldisks"></a>
# **VirtualMachineDefragmentAllDisks**
> void VirtualMachineDefragmentAllDisks (string moId)

Defragment all virtual disks attached to this virtual machine. 

Defragment all virtual disks attached to this virtual machine.  ***Required privileges:*** VirtualMachine.Interact.DefragmentAllDisks 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineDefragmentAllDisksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Defragment all virtual disks attached to this virtual machine. 
                apiInstance.VirtualMachineDefragmentAllDisks(moId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineDefragmentAllDisks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineDefragmentAllDisksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Defragment all virtual disks attached to this virtual machine. 
    apiInstance.VirtualMachineDefragmentAllDisksWithHttpInfo(moId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineDefragmentAllDisksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

void (empty response body)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content  |  -  |
| **500** | ***InvalidState***: if the virtual machine is not connected.  ***InvalidPowerState***: if the virtual machine is poweredOn.  ***TaskInProgress***: if the virtual machine is busy.  ***FileFault***: if there is an error accessing the disk files.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinedestroytask"></a>
# **VirtualMachineDestroyTask**
> ManagedObjectReference VirtualMachineDestroyTask (string moId)

Destroys this object, deleting its contents and removing it from its parent folder (if any). 

Destroys this object, deleting its contents and removing it from its parent folder (if any).  NOTE: The appropriate privilege must be held on the parent of the destroyed entity as well as the entity itself. This method can throw one of several exceptions. The exact set of exceptions depends on the kind of entity that is being removed. See comments for each entity for more information on destroy behavior.  ***Required privileges:*** VirtualMachine.Inventory.Delete 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineDestroyTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Destroys this object, deleting its contents and removing it from its parent folder (if any). 
                ManagedObjectReference result = apiInstance.VirtualMachineDestroyTask(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineDestroyTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineDestroyTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Destroys this object, deleting its contents and removing it from its parent folder (if any). 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineDestroyTaskWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineDestroyTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation.  Refers instance of *Task*.  |  -  |
| **500** | Failure  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinedetachdisktask"></a>
# **VirtualMachineDetachDiskTask**
> ManagedObjectReference VirtualMachineDetachDiskTask (string moId, DetachDiskRequestType detachDiskRequestType)

Detach a disk from this virtual machine. 

Detach a disk from this virtual machine.  ***Required privileges:*** VirtualMachine.Config.RemoveDisk 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineDetachDiskTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var detachDiskRequestType = new DetachDiskRequestType(); // DetachDiskRequestType | 

            try
            {
                // Detach a disk from this virtual machine. 
                ManagedObjectReference result = apiInstance.VirtualMachineDetachDiskTask(moId, detachDiskRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineDetachDiskTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineDetachDiskTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Detach a disk from this virtual machine. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineDetachDiskTaskWithHttpInfo(moId, detachDiskRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineDetachDiskTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **detachDiskRequestType** | [**DetachDiskRequestType**](DetachDiskRequestType.md) |  |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Refers instance of *Task*.  |  -  |
| **500** | ***NotFound***: if the disk object cannot be found.  ***VmConfigFault***: if the virtual machine&#39;s configuration is invalid.  ***FileFault***: if there is a problem creating or accessing the virtual machine&#39;s files for this operation.  ***InvalidState***: if the operation cannot be performed in the current state of the virtual machine. For example, because the virtual machine&#39;s configuration is not available.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinedisablesecondaryvmtask"></a>
# **VirtualMachineDisableSecondaryVMTask**
> ManagedObjectReference VirtualMachineDisableSecondaryVMTask (string moId, DisableSecondaryVMRequestType disableSecondaryVMRequestType)

Disables the specified secondary virtual machine in this fault tolerant group. 

Disables the specified secondary virtual machine in this fault tolerant group.  The specified secondary will not be automatically started on a subsequent power-on of the primary virtual machine. This operation could leave the primary virtual machine in a non-fault tolerant state.  ***Required privileges:*** VirtualMachine.Interact.DisableSecondary 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineDisableSecondaryVMTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var disableSecondaryVMRequestType = new DisableSecondaryVMRequestType(); // DisableSecondaryVMRequestType | 

            try
            {
                // Disables the specified secondary virtual machine in this fault tolerant group. 
                ManagedObjectReference result = apiInstance.VirtualMachineDisableSecondaryVMTask(moId, disableSecondaryVMRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineDisableSecondaryVMTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineDisableSecondaryVMTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Disables the specified secondary virtual machine in this fault tolerant group. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineDisableSecondaryVMTaskWithHttpInfo(moId, disableSecondaryVMRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineDisableSecondaryVMTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **disableSecondaryVMRequestType** | [**DisableSecondaryVMRequestType**](DisableSecondaryVMRequestType.md) |  |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation.  Refers instance of *Task*.  |  -  |
| **500** | ***VmFaultToleranceIssue***: if any error is encountered with the fault tolerance configuration of the virtual machine. Typically, a more specific fault like InvalidOperationOnSecondaryVm is thrown.  ***TaskInProgress***: if the virtual machine is busy.  ***InvalidState***: if the host is in maintenance mode or if the virtual machine&#39;s configuration information is not available.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinedropconnections"></a>
# **VirtualMachineDropConnections**
> bool VirtualMachineDropConnections (string moId, DropConnectionsRequestType? dropConnectionsRequestType = null)

Force the virtual machine to drop the specified connections. 

Force the virtual machine to drop the specified connections.  Attempt to drop the specified virtual machine connections. An attempt will be made to drop all of the specified connections before returning.  ***Since:*** vSphere API Release 7.0.1.0  ***Required privileges:*** VirtualMachine.Interact.ConsoleInteract 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineDropConnectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var dropConnectionsRequestType = new DropConnectionsRequestType?(); // DropConnectionsRequestType? |  (optional) 

            try
            {
                // Force the virtual machine to drop the specified connections. 
                bool result = apiInstance.VirtualMachineDropConnections(moId, dropConnectionsRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineDropConnections: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineDropConnectionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Force the virtual machine to drop the specified connections. 
    ApiResponse<bool> response = apiInstance.VirtualMachineDropConnectionsWithHttpInfo(moId, dropConnectionsRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineDropConnectionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **dropConnectionsRequestType** | [**DropConnectionsRequestType?**](DropConnectionsRequestType?.md) |  | [optional]  |

### Return type

**bool**

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | true All of the specified connections have been dropped.  |  -  |
| **500** | ***InvalidPowerState***: If the virtual machine is not powered on. No connection drop actions will have been attempted if this is thrown.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachineenablesecondaryvmtask"></a>
# **VirtualMachineEnableSecondaryVMTask**
> ManagedObjectReference VirtualMachineEnableSecondaryVMTask (string moId, EnableSecondaryVMRequestType enableSecondaryVMRequestType)

Enables the specified secondary virtual machine in this fault tolerant group. 

Enables the specified secondary virtual machine in this fault tolerant group.  This operation is used to enable a secondary virtual machine that was previously disabled by the *VirtualMachine.DisableSecondaryVM_Task* call. The specified secondary will be automatically started whenever the primary is powered on.  If the primary virtual machine (i.e., this virtual machine) is powered on when the secondary is enabled, an attempt will be made to power on the secondary. If a host was specified in the method call, this host will be used. If a host is not specified, one will be selected by the system. In the latter case, if the cluster is a DRS cluster, DRS will be invoked to obtain a placement for the new secondary virtual machine. If the DRS recommendation (see *ClusterRecommendation*) is automatic, it will be executed. Otherwise, the recommendation will be returned to the caller of this method and the secondary will remain powered off until the recommendation is approved using *ClusterComputeResource.ApplyRecommendation*.  ***Required privileges:*** VirtualMachine.Interact.EnableSecondary 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineEnableSecondaryVMTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var enableSecondaryVMRequestType = new EnableSecondaryVMRequestType(); // EnableSecondaryVMRequestType | 

            try
            {
                // Enables the specified secondary virtual machine in this fault tolerant group. 
                ManagedObjectReference result = apiInstance.VirtualMachineEnableSecondaryVMTask(moId, enableSecondaryVMRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineEnableSecondaryVMTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineEnableSecondaryVMTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Enables the specified secondary virtual machine in this fault tolerant group. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineEnableSecondaryVMTaskWithHttpInfo(moId, enableSecondaryVMRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineEnableSecondaryVMTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **enableSecondaryVMRequestType** | [**EnableSecondaryVMRequestType**](EnableSecondaryVMRequestType.md) |  |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation. The *info.result* property in the *Task* returns an instance of the *FaultToleranceSecondaryOpResult* data object, which contains a reference to the *VirtualMachine* and the status of powering it on, if attempted.  Refers instance of *Task*.  |  -  |
| **500** | ***VmConfigFault***: if a configuration issue prevents enabling the secondary. Typically, a more specific fault such as VmConfigIncompatibleForFaultTolerance is thrown.  ***VmFaultToleranceIssue***: if any error is encountered with the fault tolerance configuration of the virtual machine. Typically, a more specific fault like InvalidOperationOnSecondaryVm is thrown.  ***TaskInProgress***: if the virtual machine is busy.  ***ManagedObjectNotFound***: if a host is specified and it does not exist.  ***InvalidState***: if the virtual machine&#39;s configuration information is not available, if the secondary virtual machine is not disabled, or if a power-on is attempted and one is already in progress.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachineestimatestorageforconsolidatesnapshotstask"></a>
# **VirtualMachineEstimateStorageForConsolidateSnapshotsTask**
> ManagedObjectReference VirtualMachineEstimateStorageForConsolidateSnapshotsTask (string moId)

Estimate the temporary space required to consolidation disk files. 

Estimate the temporary space required to consolidation disk files.  The estimation is a lower bound if the childmost writable disk file will be consolidated for an online virtual machine, it is accurate for all other situations. This is because the space requirement depending on the size of the childmost disk file and how write intensive the guest is.  This method can be used prior to invoke consolidation via *VirtualMachine.ConsolidateVMDisks_Task*.  ***Required privileges:*** VirtualMachine.State.RemoveSnapshot 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineEstimateStorageForConsolidateSnapshotsTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Estimate the temporary space required to consolidation disk files. 
                ManagedObjectReference result = apiInstance.VirtualMachineEstimateStorageForConsolidateSnapshotsTask(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineEstimateStorageForConsolidateSnapshotsTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineEstimateStorageForConsolidateSnapshotsTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Estimate the temporary space required to consolidation disk files. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineEstimateStorageForConsolidateSnapshotsTaskWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineEstimateStorageForConsolidateSnapshotsTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation.  Refers instance of *Task*.  |  -  |
| **500** | ***TaskInProgress***: if the virtual machine is busy.  ***InvalidState***: if the operation cannot be performed because of the virtual machine&#39;s current state. For example, if the virtual machine configuration information is not available.  ***FileFault***: if if there is a problem accessing the virtual machine&#39;s files for this operation. Typically a more specific fault *FileLocked* is thrown.  ***VmConfigFault***: if a virtual machine configuration issue prevents the estimation. Typically, a more specific fault is thrown.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachineexportvm"></a>
# **VirtualMachineExportVm**
> ManagedObjectReference VirtualMachineExportVm (string moId)

Obtains an export lease on this virtual machine. 

Obtains an export lease on this virtual machine.  The export lease contains a list of URLs for the virtual disks for this virtual machine, as well as a ticket giving access to the URLs.  See *HttpNfcLease* for information on how to use the lease.  ***Required privileges:*** VApp.Export 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineExportVmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Obtains an export lease on this virtual machine. 
                ManagedObjectReference result = apiInstance.VirtualMachineExportVm(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineExportVm: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineExportVmWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Obtains an export lease on this virtual machine. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineExportVmWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineExportVmWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The export lease on this *VirtualMachine*. The export task continues running until the lease is completed by the caller.  Refers instance of *HttpNfcLease*.  |  -  |
| **500** | ***InvalidPowerState***: if the virtual machine is powered on.  ***TaskInProgress***: if the virtual machine is busy.  ***InvalidState***: if the operation cannot be performed because of the virtual machine&#39;s current state. For example, if the virtual machine configuration information is not available.  ***FileFault***: if there is an error accessing the virtual machine files.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachineextractovfenvironment"></a>
# **VirtualMachineExtractOvfEnvironment**
> string VirtualMachineExtractOvfEnvironment (string moId)

Returns the OVF environment for a virtual machine. 

Returns the OVF environment for a virtual machine.  If the virtual machine has no vApp configuration, an empty string is returned. Also, sensitive information is omitted, so this method is not guaranteed to return the complete OVF environment.  ***Required privileges:*** VApp.ExtractOvfEnvironment 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineExtractOvfEnvironmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Returns the OVF environment for a virtual machine. 
                string result = apiInstance.VirtualMachineExtractOvfEnvironment(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineExtractOvfEnvironment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineExtractOvfEnvironmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns the OVF environment for a virtual machine. 
    ApiResponse<string> response = apiInstance.VirtualMachineExtractOvfEnvironmentWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineExtractOvfEnvironmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

**string**

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |
| **500** | ***InvalidState***: if the virtual machine is not running  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegetalarmactionsenabled"></a>
# **VirtualMachineGetAlarmActionsEnabled**
> bool? VirtualMachineGetAlarmActionsEnabled (string moId)

Whether alarm actions are enabled for this entity. 

Whether alarm actions are enabled for this entity.  True if enabled; false otherwise.  ***Required privileges:*** System.Read 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetAlarmActionsEnabledExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Whether alarm actions are enabled for this entity. 
                bool? result = apiInstance.VirtualMachineGetAlarmActionsEnabled(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetAlarmActionsEnabled: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetAlarmActionsEnabledWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Whether alarm actions are enabled for this entity. 
    ApiResponse<bool?> response = apiInstance.VirtualMachineGetAlarmActionsEnabledWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetAlarmActionsEnabledWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

**bool?**

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegetavailablefield"></a>
# **VirtualMachineGetAvailableField**
> List&lt;CustomFieldDef&gt; VirtualMachineGetAvailableField (string moId)

List of custom field definitions that are valid for the object's type. 

List of custom field definitions that are valid for the object's type.  The fields are sorted by *CustomFieldDef.name*.  ***Required privileges:*** System.View 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetAvailableFieldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // List of custom field definitions that are valid for the object's type. 
                List<CustomFieldDef> result = apiInstance.VirtualMachineGetAvailableField(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetAvailableField: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetAvailableFieldWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List of custom field definitions that are valid for the object's type. 
    ApiResponse<List<CustomFieldDef>> response = apiInstance.VirtualMachineGetAvailableFieldWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetAvailableFieldWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**List&lt;CustomFieldDef&gt;**](CustomFieldDef.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegetcapability"></a>
# **VirtualMachineGetCapability**
> VirtualMachineCapability VirtualMachineGetCapability (string moId)

Information about the runtime capabilities of this virtual machine. 

Information about the runtime capabilities of this virtual machine. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetCapabilityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Information about the runtime capabilities of this virtual machine. 
                VirtualMachineCapability result = apiInstance.VirtualMachineGetCapability(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetCapability: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetCapabilityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Information about the runtime capabilities of this virtual machine. 
    ApiResponse<VirtualMachineCapability> response = apiInstance.VirtualMachineGetCapabilityWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetCapabilityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**VirtualMachineCapability**](VirtualMachineCapability.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegetconfig"></a>
# **VirtualMachineGetConfig**
> VirtualMachineConfigInfo VirtualMachineGetConfig (string moId)

Configuration of this virtual machine, including the name and UUID. 

Configuration of this virtual machine, including the name and UUID.  This property is set when a virtual machine is created or when the *reconfigVM* method is called.  The virtual machine configuration is not guaranteed to be available. For example, the configuration information would be unavailable if the server is unable to access the virtual machine files on disk, and is often also unavailable during the initial phases of virtual machine creation. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Configuration of this virtual machine, including the name and UUID. 
                VirtualMachineConfigInfo result = apiInstance.VirtualMachineGetConfig(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetConfig: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetConfigWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Configuration of this virtual machine, including the name and UUID. 
    ApiResponse<VirtualMachineConfigInfo> response = apiInstance.VirtualMachineGetConfigWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetConfigWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**VirtualMachineConfigInfo**](VirtualMachineConfigInfo.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegetconfigissue"></a>
# **VirtualMachineGetConfigIssue**
> List&lt;Event&gt; VirtualMachineGetConfigIssue (string moId)

Current configuration issues that have been detected for this entity. 

Current configuration issues that have been detected for this entity.  Typically, these issues have already been logged as events. The entity stores these events as long as they are still current. The *configStatus* property provides an overall status based on these events. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetConfigIssueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Current configuration issues that have been detected for this entity. 
                List<Event> result = apiInstance.VirtualMachineGetConfigIssue(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetConfigIssue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetConfigIssueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Current configuration issues that have been detected for this entity. 
    ApiResponse<List<Event>> response = apiInstance.VirtualMachineGetConfigIssueWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetConfigIssueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**List&lt;Event&gt;**](Event.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegetconfigstatus"></a>
# **VirtualMachineGetConfigStatus**
> ManagedEntityStatusEnum VirtualMachineGetConfigStatus (string moId)

The configStatus indicates whether or not the system has detected a configuration issue involving this entity. 

The configStatus indicates whether or not the system has detected a configuration issue involving this entity.  For example, it might have detected a duplicate IP address or MAC address, or a host in a cluster might be out of compliance. The meanings of the configStatus values are: - red: A problem has been detected involving the entity. - yellow: A problem is about to occur or a transient condition   has occurred (For example, reconfigure fail-over policy). - green: No configuration issues have been detected. - gray: The configuration status of the entity is not being monitored.    A green status indicates only that a problem has not been detected; it is not a guarantee that the entity is problem-free.  The *configIssue* property contains a list of the problems that have been detected. In releases after vSphere API 5.0, vSphere Servers might not generate property collector update notifications for this property. To obtain the latest value of the property, you can use PropertyCollector methods RetrievePropertiesEx or WaitForUpdatesEx. If you use the PropertyCollector.WaitForUpdatesEx method, specify an empty string for the version parameter. Any other version value will not produce any property values as no updates are generated. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetConfigStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // The configStatus indicates whether or not the system has detected a configuration issue involving this entity. 
                ManagedEntityStatusEnum result = apiInstance.VirtualMachineGetConfigStatus(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetConfigStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetConfigStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The configStatus indicates whether or not the system has detected a configuration issue involving this entity. 
    ApiResponse<ManagedEntityStatusEnum> response = apiInstance.VirtualMachineGetConfigStatusWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetConfigStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**ManagedEntityStatusEnum**](ManagedEntityStatusEnum.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegetcustomvalue"></a>
# **VirtualMachineGetCustomValue**
> List&lt;CustomFieldValue&gt; VirtualMachineGetCustomValue (string moId)

Custom field values. 

Custom field values.  ***Required privileges:*** System.View 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetCustomValueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Custom field values. 
                List<CustomFieldValue> result = apiInstance.VirtualMachineGetCustomValue(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetCustomValue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetCustomValueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Custom field values. 
    ApiResponse<List<CustomFieldValue>> response = apiInstance.VirtualMachineGetCustomValueWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetCustomValueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**List&lt;CustomFieldValue&gt;**](CustomFieldValue.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegetdatastore"></a>
# **VirtualMachineGetDatastore**
> List&lt;ManagedObjectReference&gt; VirtualMachineGetDatastore (string moId)

A collection of references to the subset of datastore objects in the datacenter that is used by this virtual machine. 

A collection of references to the subset of datastore objects in the datacenter that is used by this virtual machine.  ***Required privileges:*** System.View 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetDatastoreExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // A collection of references to the subset of datastore objects in the datacenter that is used by this virtual machine. 
                List<ManagedObjectReference> result = apiInstance.VirtualMachineGetDatastore(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetDatastore: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetDatastoreWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // A collection of references to the subset of datastore objects in the datacenter that is used by this virtual machine. 
    ApiResponse<List<ManagedObjectReference>> response = apiInstance.VirtualMachineGetDatastoreWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetDatastoreWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Refers instances of *Datastore*.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegetdeclaredalarmstate"></a>
# **VirtualMachineGetDeclaredAlarmState**
> List&lt;AlarmState&gt; VirtualMachineGetDeclaredAlarmState (string moId)

A set of alarm states for alarms that apply to this managed entity. 

A set of alarm states for alarms that apply to this managed entity.  The set includes alarms defined on this entity and alarms inherited from the parent entity, or from any ancestors in the inventory hierarchy.  Alarms are inherited if they can be triggered by this entity or its descendants. This set does not include alarms that are defined on descendants of this entity.  ***Required privileges:*** System.View 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetDeclaredAlarmStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // A set of alarm states for alarms that apply to this managed entity. 
                List<AlarmState> result = apiInstance.VirtualMachineGetDeclaredAlarmState(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetDeclaredAlarmState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetDeclaredAlarmStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // A set of alarm states for alarms that apply to this managed entity. 
    ApiResponse<List<AlarmState>> response = apiInstance.VirtualMachineGetDeclaredAlarmStateWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetDeclaredAlarmStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**List&lt;AlarmState&gt;**](AlarmState.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegetdisabledmethod"></a>
# **VirtualMachineGetDisabledMethod**
> List&lt;string&gt; VirtualMachineGetDisabledMethod (string moId)

List of operations that are disabled, given the current runtime state of the entity. 

List of operations that are disabled, given the current runtime state of the entity.  For example, a power-on operation always fails if a virtual machine is already powered on. This list can be used by clients to enable or disable operations in a graphical user interface.  Note: This list is determined by the current runtime state of an entity, not by its permissions.  This list may include the following operations for a HostSystem: - *HostSystem.EnterMaintenanceMode_Task* - *HostSystem.ExitMaintenanceMode_Task* - *HostSystem.RebootHost_Task* - *HostSystem.ShutdownHost_Task* - *HostSystem.ReconnectHost_Task* - *HostSystem.DisconnectHost_Task*    This list may include the following operations for a VirtualMachine: - *VirtualMachine.AnswerVM* - *ManagedEntity.Rename_Task* - *VirtualMachine.CloneVM_Task* - *VirtualMachine.PowerOffVM_Task* - *VirtualMachine.PowerOnVM_Task* - *VirtualMachine.SuspendVM_Task* - *VirtualMachine.ResetVM_Task* - *VirtualMachine.ReconfigVM_Task* - *VirtualMachine.RelocateVM_Task* - *VirtualMachine.MigrateVM_Task* - *VirtualMachine.CustomizeVM_Task* - *VirtualMachine.ShutdownGuest* - *VirtualMachine.StandbyGuest* - *VirtualMachine.RebootGuest* - *VirtualMachine.CreateSnapshot_Task* - *VirtualMachine.RemoveAllSnapshots_Task* - *VirtualMachine.RevertToCurrentSnapshot_Task* - *VirtualMachine.MarkAsTemplate* - *VirtualMachine.MarkAsVirtualMachine* - *VirtualMachine.ResetGuestInformation* - *VirtualMachine.MountToolsInstaller* - *VirtualMachine.UnmountToolsInstaller* - *ManagedEntity.Destroy_Task* - *VirtualMachine.UpgradeVM_Task* - *VirtualMachine.ExportVm*    This list may include the following operations for a ResourcePool: - *ResourcePool.ImportVApp* - *ResourcePool.CreateChildVM_Task* - *ResourcePool.UpdateConfig* - *Folder.CreateVM_Task* - *ManagedEntity.Destroy_Task* - *ManagedEntity.Rename_Task*    This list may include the following operations for a VirtualApp: - *ManagedEntity.Destroy_Task* - *VirtualApp.CloneVApp_Task* - *VirtualApp.unregisterVApp_Task* - *VirtualApp.ExportVApp* - *VirtualApp.PowerOnVApp_Task* - *VirtualApp.PowerOffVApp_Task* - *VirtualApp.UpdateVAppConfig*    In releases after vSphere API 5.0, vSphere Servers might not generate property collector update notifications for this property. To obtain the latest value of the property, you can use PropertyCollector methods RetrievePropertiesEx or WaitForUpdatesEx. If you use the PropertyCollector.WaitForUpdatesEx method, specify an empty string for the version parameter. Any other version value will not produce any property values as no updates are generated. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetDisabledMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // List of operations that are disabled, given the current runtime state of the entity. 
                List<string> result = apiInstance.VirtualMachineGetDisabledMethod(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetDisabledMethod: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetDisabledMethodWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List of operations that are disabled, given the current runtime state of the entity. 
    ApiResponse<List<string>> response = apiInstance.VirtualMachineGetDisabledMethodWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetDisabledMethodWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

**List<string>**

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegeteffectiverole"></a>
# **VirtualMachineGetEffectiveRole**
> List&lt;int&gt; VirtualMachineGetEffectiveRole (string moId)

Access rights the current session has to this entity. 

Access rights the current session has to this entity.  ***Required privileges:*** System.View 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetEffectiveRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Access rights the current session has to this entity. 
                List<int> result = apiInstance.VirtualMachineGetEffectiveRole(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetEffectiveRole: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetEffectiveRoleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Access rights the current session has to this entity. 
    ApiResponse<List<int>> response = apiInstance.VirtualMachineGetEffectiveRoleWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetEffectiveRoleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

**List<int>**

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegetenvironmentbrowser"></a>
# **VirtualMachineGetEnvironmentBrowser**
> ManagedObjectReference VirtualMachineGetEnvironmentBrowser (string moId)

The current virtual machine's environment browser object. 

The current virtual machine's environment browser object.  This contains information on all the configurations that can be used on the virtual machine. This is identical to the environment browser on the *ComputeResource* to which this virtual machine belongs. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetEnvironmentBrowserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // The current virtual machine's environment browser object. 
                ManagedObjectReference result = apiInstance.VirtualMachineGetEnvironmentBrowser(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetEnvironmentBrowser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetEnvironmentBrowserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The current virtual machine's environment browser object. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineGetEnvironmentBrowserWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetEnvironmentBrowserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Refers instance of *EnvironmentBrowser*.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegetguest"></a>
# **VirtualMachineGetGuest**
> GuestInfo VirtualMachineGetGuest (string moId)

Information about VMware Tools and about the virtual machine from the perspective of VMware Tools. 

Information about VMware Tools and about the virtual machine from the perspective of VMware Tools.  Information about the guest operating system is available in VirtualCenter. Guest operating system information reflects the last known state of the virtual machine. For powered on machines, this is current information. For powered off machines, this is the last recorded state before the virtual machine was powered off. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetGuestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Information about VMware Tools and about the virtual machine from the perspective of VMware Tools. 
                GuestInfo result = apiInstance.VirtualMachineGetGuest(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetGuest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetGuestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Information about VMware Tools and about the virtual machine from the perspective of VMware Tools. 
    ApiResponse<GuestInfo> response = apiInstance.VirtualMachineGetGuestWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetGuestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**GuestInfo**](GuestInfo.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegetguestheartbeatstatus"></a>
# **VirtualMachineGetGuestHeartbeatStatus**
> ManagedEntityStatusEnum VirtualMachineGetGuestHeartbeatStatus (string moId)

The guest heartbeat. 

The guest heartbeat.  The heartbeat status is classified as: - gray - VMware Tools are not installed or not running. - red - No heartbeat. Guest operating system may have stopped responding. - yellow - Intermittent heartbeat. May be due to guest load. - green - Guest operating system is responding normally.    The guest heartbeat is a statistics metric. Alarms can be configured on this metric to trigger emails or other actions. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetGuestHeartbeatStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // The guest heartbeat. 
                ManagedEntityStatusEnum result = apiInstance.VirtualMachineGetGuestHeartbeatStatus(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetGuestHeartbeatStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetGuestHeartbeatStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The guest heartbeat. 
    ApiResponse<ManagedEntityStatusEnum> response = apiInstance.VirtualMachineGetGuestHeartbeatStatusWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetGuestHeartbeatStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**ManagedEntityStatusEnum**](ManagedEntityStatusEnum.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegetlayout"></a>
# **VirtualMachineGetLayout**
> VirtualMachineFileLayout VirtualMachineGetLayout (string moId)

Detailed information about the files that comprise this virtual machine. 

Deprecated as of vSphere API 4.0, use *VirtualMachine.layoutEx* instead. In releases after vSphere API 5.0, vSphere Servers might not generate property collector update notifications for this property. To obtain the latest value of the property, you can use PropertyCollector methods RetrievePropertiesEx or WaitForUpdatesEx. If you use the PropertyCollector.WaitForUpdatesEx method, specify an empty string for the version parameter. Any other version value will not produce any property values as no updates are generated.  Detailed information about the files that comprise this virtual machine. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetLayoutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Detailed information about the files that comprise this virtual machine. 
                VirtualMachineFileLayout result = apiInstance.VirtualMachineGetLayout(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetLayout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetLayoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Detailed information about the files that comprise this virtual machine. 
    ApiResponse<VirtualMachineFileLayout> response = apiInstance.VirtualMachineGetLayoutWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetLayoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**VirtualMachineFileLayout**](VirtualMachineFileLayout.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegetlayoutex"></a>
# **VirtualMachineGetLayoutEx**
> VirtualMachineFileLayoutEx VirtualMachineGetLayoutEx (string moId)

Detailed information about the files that comprise this virtual machine. 

Detailed information about the files that comprise this virtual machine.  Can be explicitly refreshed by the *VirtualMachine.RefreshStorageInfo* operation. In releases after vSphere API 5.0, vSphere Servers might not generate property collector update notifications for this property. To obtain the latest value of the property, you can use PropertyCollector methods RetrievePropertiesEx or WaitForUpdatesEx. If you use the PropertyCollector.WaitForUpdatesEx method, specify an empty string for the version parameter. Any other version value will not produce any property values as no updates are generated. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetLayoutExExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Detailed information about the files that comprise this virtual machine. 
                VirtualMachineFileLayoutEx result = apiInstance.VirtualMachineGetLayoutEx(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetLayoutEx: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetLayoutExWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Detailed information about the files that comprise this virtual machine. 
    ApiResponse<VirtualMachineFileLayoutEx> response = apiInstance.VirtualMachineGetLayoutExWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetLayoutExWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**VirtualMachineFileLayoutEx**](VirtualMachineFileLayoutEx.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegetname"></a>
# **VirtualMachineGetName**
> string VirtualMachineGetName (string moId)

Name of this entity, unique relative to its parent. 

Name of this entity, unique relative to its parent.  Any / (slash), \\\\ (backslash), character used in this name element will be escaped. Similarly, any % (percent) character used in this name element will be escaped, unless it is used to start an escape sequence. A slash is escaped as %2F or %2f. A backslash is escaped as %5C or %5c, and a percent is escaped as %25.  ***Required privileges:*** System.View 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Name of this entity, unique relative to its parent. 
                string result = apiInstance.VirtualMachineGetName(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Name of this entity, unique relative to its parent. 
    ApiResponse<string> response = apiInstance.VirtualMachineGetNameWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

**string**

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegetnetwork"></a>
# **VirtualMachineGetNetwork**
> List&lt;ManagedObjectReference&gt; VirtualMachineGetNetwork (string moId)

A collection of references to the subset of network objects in the datacenter that is used by this virtual machine. 

A collection of references to the subset of network objects in the datacenter that is used by this virtual machine.  ***Required privileges:*** System.View 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetNetworkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // A collection of references to the subset of network objects in the datacenter that is used by this virtual machine. 
                List<ManagedObjectReference> result = apiInstance.VirtualMachineGetNetwork(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetNetwork: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetNetworkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // A collection of references to the subset of network objects in the datacenter that is used by this virtual machine. 
    ApiResponse<List<ManagedObjectReference>> response = apiInstance.VirtualMachineGetNetworkWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetNetworkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Refers instances of *Network*.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegetoverallstatus"></a>
# **VirtualMachineGetOverallStatus**
> ManagedEntityStatusEnum VirtualMachineGetOverallStatus (string moId)

General health of this managed entity. 

General health of this managed entity.  The overall status of the managed entity is computed as the worst status among its alarms and the configuration issues detected on the entity. The status is reported as one of the following values: - red: The entity has alarms or configuration issues with a red status. - yellow: The entity does not have alarms or configuration issues with a   red status, and has at least one with a yellow status. - green: The entity does not have alarms or configuration issues with a   red or yellow status, and has at least one with a green status. - gray: All of the entity's alarms have a gray status and the   configuration status of the entity is not being monitored.    In releases after vSphere API 5.0, vSphere Servers might not generate property collector update notifications for this property. To obtain the latest value of the property, you can use PropertyCollector methods RetrievePropertiesEx or WaitForUpdatesEx. If you use the PropertyCollector.WaitForUpdatesEx method, specify an empty string for the version parameter. Any other version value will not produce any property values as no updates are generated. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetOverallStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // General health of this managed entity. 
                ManagedEntityStatusEnum result = apiInstance.VirtualMachineGetOverallStatus(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetOverallStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetOverallStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // General health of this managed entity. 
    ApiResponse<ManagedEntityStatusEnum> response = apiInstance.VirtualMachineGetOverallStatusWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetOverallStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**ManagedEntityStatusEnum**](ManagedEntityStatusEnum.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegetparent"></a>
# **VirtualMachineGetParent**
> ManagedObjectReference VirtualMachineGetParent (string moId)

Parent of this entity. 

Parent of this entity.  This value is null for the root object and for *VirtualMachine* objects that are part of a *VirtualApp*.  ***Required privileges:*** System.View 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetParentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Parent of this entity. 
                ManagedObjectReference result = apiInstance.VirtualMachineGetParent(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetParent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetParentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Parent of this entity. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineGetParentWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetParentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Refers instance of *ManagedEntity*.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegetparentvapp"></a>
# **VirtualMachineGetParentVApp**
> ManagedObjectReference VirtualMachineGetParentVApp (string moId)

Reference to the parent vApp. 

Reference to the parent vApp. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetParentVAppExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Reference to the parent vApp. 
                ManagedObjectReference result = apiInstance.VirtualMachineGetParentVApp(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetParentVApp: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetParentVAppWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reference to the parent vApp. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineGetParentVAppWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetParentVAppWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Refers instance of *ManagedEntity*.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegetpermission"></a>
# **VirtualMachineGetPermission**
> List&lt;Permission&gt; VirtualMachineGetPermission (string moId)

List of the permissions explicitly defined for this entity. 

List of the permissions explicitly defined for this entity. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetPermissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // List of the permissions explicitly defined for this entity. 
                List<Permission> result = apiInstance.VirtualMachineGetPermission(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetPermission: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetPermissionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List of the permissions explicitly defined for this entity. 
    ApiResponse<List<Permission>> response = apiInstance.VirtualMachineGetPermissionWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetPermissionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**List&lt;Permission&gt;**](Permission.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegetrecenttask"></a>
# **VirtualMachineGetRecentTask**
> List&lt;ManagedObjectReference&gt; VirtualMachineGetRecentTask (string moId)

The set of recent tasks operating on this managed entity. 

The set of recent tasks operating on this managed entity.  This is a subset of *TaskManager.recentTask* belong to this entity. A task in this list could be in one of the four states: pending, running, success or error.  This property can be used to deduce intermediate power states for a virtual machine entity. For example, if the current powerState is \"poweredOn\" and there is a running task performing the \"suspend\" operation, then the virtual machine's intermediate state might be described as \"suspending.\"  Most tasks (such as power operations) obtain exclusive access to the virtual machine, so it is unusual for this list to contain more than one running task. One exception, however, is the task of cloning a virtual machine. In releases after vSphere API 5.0, vSphere Servers might not generate property collector update notifications for this property. To obtain the latest value of the property, you can use PropertyCollector methods RetrievePropertiesEx or WaitForUpdatesEx. If you use the PropertyCollector.WaitForUpdatesEx method, specify an empty string for the version parameter. Any other version value will not produce any property values as no updates are generated. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetRecentTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // The set of recent tasks operating on this managed entity. 
                List<ManagedObjectReference> result = apiInstance.VirtualMachineGetRecentTask(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetRecentTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetRecentTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The set of recent tasks operating on this managed entity. 
    ApiResponse<List<ManagedObjectReference>> response = apiInstance.VirtualMachineGetRecentTaskWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetRecentTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Refers instances of *Task*.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegetresourceconfig"></a>
# **VirtualMachineGetResourceConfig**
> ResourceConfigSpec VirtualMachineGetResourceConfig (string moId)

The resource configuration for a virtual machine. 

The resource configuration for a virtual machine.  The shares in this specification are evaluated relative to the resource pool to which it is assigned. This will return null if the product the virtual machine is registered on does not support resource configuration.  To retrieve the configuration, you typically use *childConfiguration*.  To change the configuration, use *ResourcePool.UpdateChildResourceConfiguration*. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetResourceConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // The resource configuration for a virtual machine. 
                ResourceConfigSpec result = apiInstance.VirtualMachineGetResourceConfig(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetResourceConfig: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetResourceConfigWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The resource configuration for a virtual machine. 
    ApiResponse<ResourceConfigSpec> response = apiInstance.VirtualMachineGetResourceConfigWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetResourceConfigWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**ResourceConfigSpec**](ResourceConfigSpec.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegetresourcepool"></a>
# **VirtualMachineGetResourcePool**
> ManagedObjectReference VirtualMachineGetResourcePool (string moId)

The current resource pool that specifies resource allocation for this virtual machine. 

The current resource pool that specifies resource allocation for this virtual machine.  This property is set when a virtual machine is created or associated with a different resource pool.  Returns null if the virtual machine is a template or the session has no access to the resource pool. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetResourcePoolExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // The current resource pool that specifies resource allocation for this virtual machine. 
                ManagedObjectReference result = apiInstance.VirtualMachineGetResourcePool(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetResourcePool: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetResourcePoolWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The current resource pool that specifies resource allocation for this virtual machine. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineGetResourcePoolWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetResourcePoolWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Refers instance of *ResourcePool*.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegetrootsnapshot"></a>
# **VirtualMachineGetRootSnapshot**
> List&lt;ManagedObjectReference&gt; VirtualMachineGetRootSnapshot (string moId)

The roots of all snapshot trees for the virtual machine. 

The roots of all snapshot trees for the virtual machine. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetRootSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // The roots of all snapshot trees for the virtual machine. 
                List<ManagedObjectReference> result = apiInstance.VirtualMachineGetRootSnapshot(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetRootSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetRootSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The roots of all snapshot trees for the virtual machine. 
    ApiResponse<List<ManagedObjectReference>> response = apiInstance.VirtualMachineGetRootSnapshotWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetRootSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Refers instances of *VirtualMachineSnapshot*.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegetruntime"></a>
# **VirtualMachineGetRuntime**
> VirtualMachineRuntimeInfo VirtualMachineGetRuntime (string moId)

Execution state and history for this virtual machine. 

Execution state and history for this virtual machine.  The contents of this property change when: - the virtual machine's power state changes. - an execution message is pending. - an event occurs. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetRuntimeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Execution state and history for this virtual machine. 
                VirtualMachineRuntimeInfo result = apiInstance.VirtualMachineGetRuntime(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetRuntime: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetRuntimeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Execution state and history for this virtual machine. 
    ApiResponse<VirtualMachineRuntimeInfo> response = apiInstance.VirtualMachineGetRuntimeWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetRuntimeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**VirtualMachineRuntimeInfo**](VirtualMachineRuntimeInfo.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegetsnapshot"></a>
# **VirtualMachineGetSnapshot**
> VirtualMachineSnapshotInfo VirtualMachineGetSnapshot (string moId)

Current snapshot and tree. 

Current snapshot and tree.  The property is valid if snapshots have been created for this virtual machine.  The contents of this property change in response to the methods: - *createSnapshot* - *revertToCurrentSnapshot* - *remove* - *revert* - *removeAllSnapshots* 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Current snapshot and tree. 
                VirtualMachineSnapshotInfo result = apiInstance.VirtualMachineGetSnapshot(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Current snapshot and tree. 
    ApiResponse<VirtualMachineSnapshotInfo> response = apiInstance.VirtualMachineGetSnapshotWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**VirtualMachineSnapshotInfo**](VirtualMachineSnapshotInfo.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegetstorage"></a>
# **VirtualMachineGetStorage**
> VirtualMachineStorageInfo VirtualMachineGetStorage (string moId)

Storage space used by the virtual machine, split by datastore. 

Storage space used by the virtual machine, split by datastore.  Can be explicitly refreshed by the *VirtualMachine.RefreshStorageInfo* operation. In releases after vSphere API 5.0, vSphere Servers might not generate property collector update notifications for this property. To obtain the latest value of the property, you can use PropertyCollector methods RetrievePropertiesEx or WaitForUpdatesEx. If you use the PropertyCollector.WaitForUpdatesEx method, specify an empty string for the version parameter. Any other version value will not produce any property values as no updates are generated. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetStorageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Storage space used by the virtual machine, split by datastore. 
                VirtualMachineStorageInfo result = apiInstance.VirtualMachineGetStorage(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetStorage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetStorageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Storage space used by the virtual machine, split by datastore. 
    ApiResponse<VirtualMachineStorageInfo> response = apiInstance.VirtualMachineGetStorageWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetStorageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**VirtualMachineStorageInfo**](VirtualMachineStorageInfo.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegetsummary"></a>
# **VirtualMachineGetSummary**
> VirtualMachineSummary VirtualMachineGetSummary (string moId)

Basic information about this virtual machine. 

Basic information about this virtual machine.  This includes: - runtimeInfo - guest - basic configuration - alarms - performance information 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Basic information about this virtual machine. 
                VirtualMachineSummary result = apiInstance.VirtualMachineGetSummary(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Basic information about this virtual machine. 
    ApiResponse<VirtualMachineSummary> response = apiInstance.VirtualMachineGetSummaryWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**VirtualMachineSummary**](VirtualMachineSummary.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegettag"></a>
# **VirtualMachineGetTag**
> List&lt;Tag&gt; VirtualMachineGetTag (string moId)

The set of tags associated with this managed entity. 

The set of tags associated with this managed entity.  Experimental. Subject to change.  ***Required privileges:*** System.View 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // The set of tags associated with this managed entity. 
                List<Tag> result = apiInstance.VirtualMachineGetTag(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetTag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetTagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The set of tags associated with this managed entity. 
    ApiResponse<List<Tag>> response = apiInstance.VirtualMachineGetTagWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetTagWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**List&lt;Tag&gt;**](Tag.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegettriggeredalarmstate"></a>
# **VirtualMachineGetTriggeredAlarmState**
> List&lt;AlarmState&gt; VirtualMachineGetTriggeredAlarmState (string moId)

A set of alarm states for alarms triggered by this entity or by its descendants. 

A set of alarm states for alarms triggered by this entity or by its descendants.  Triggered alarms are propagated up the inventory hierarchy so that a user can readily tell when a descendant has triggered an alarm. In releases after vSphere API 5.0, vSphere Servers might not generate property collector update notifications for this property. To obtain the latest value of the property, you can use PropertyCollector methods RetrievePropertiesEx or WaitForUpdatesEx. If you use the PropertyCollector.WaitForUpdatesEx method, specify an empty string for the version parameter. Any other version value will not produce any property values as no updates are generated.  ***Required privileges:*** System.View 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetTriggeredAlarmStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // A set of alarm states for alarms triggered by this entity or by its descendants. 
                List<AlarmState> result = apiInstance.VirtualMachineGetTriggeredAlarmState(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetTriggeredAlarmState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetTriggeredAlarmStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // A set of alarm states for alarms triggered by this entity or by its descendants. 
    ApiResponse<List<AlarmState>> response = apiInstance.VirtualMachineGetTriggeredAlarmStateWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetTriggeredAlarmStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**List&lt;AlarmState&gt;**](AlarmState.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinegetvalue"></a>
# **VirtualMachineGetValue**
> List&lt;CustomFieldValue&gt; VirtualMachineGetValue (string moId)

List of custom field values. 

List of custom field values.  Each value uses a key to associate an instance of a *CustomFieldStringValue* with a custom field definition.  ***Required privileges:*** System.View 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineGetValueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // List of custom field values. 
                List<CustomFieldValue> result = apiInstance.VirtualMachineGetValue(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetValue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineGetValueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List of custom field values. 
    ApiResponse<List<CustomFieldValue>> response = apiInstance.VirtualMachineGetValueWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineGetValueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**List&lt;CustomFieldValue&gt;**](CustomFieldValue.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachineinstantclonetask"></a>
# **VirtualMachineInstantCloneTask**
> ManagedObjectReference VirtualMachineInstantCloneTask (string moId, InstantCloneRequestType instantCloneRequestType)

Creates a powered-on Instant Clone of a virtual machine. 

Creates a powered-on Instant Clone of a virtual machine.  The new virtual machine will be created on the same host and start with the identical running point as the original virtual machine, sharing memory state when possible and sharing disk state. The original virtual machine must be in a powered-on state. The privilege required for Instant Clone operation are: - VirtualMachine.Provisioning.Clone - VirtualMachine.Interact.PowerOn - VirtualMachine.Inventory.CreateFromExisting - Datastore.AllocateSpace - Resource.AssignVMToPool    ***Required privileges:*** VirtualMachine.Provisioning.Clone 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineInstantCloneTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var instantCloneRequestType = new InstantCloneRequestType(); // InstantCloneRequestType | 

            try
            {
                // Creates a powered-on Instant Clone of a virtual machine. 
                ManagedObjectReference result = apiInstance.VirtualMachineInstantCloneTask(moId, instantCloneRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineInstantCloneTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineInstantCloneTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a powered-on Instant Clone of a virtual machine. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineInstantCloneTaskWithHttpInfo(moId, instantCloneRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineInstantCloneTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **instantCloneRequestType** | [**InstantCloneRequestType**](InstantCloneRequestType.md) |  |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation.  Refers instance of *Task*.  |  -  |
| **500** | ***InvalidArgument***: in the following cases: - Source virtual machine is not powered on - Source virtual machine configuration is not supported for   Instant Clone operation - Relocation specification has unsupported settings     ***InvalidState***: if the operation cannot be performed because of the host or virtual machine&#39;s current state. For example, if the host is in maintenance mode or if the source virtual machine is not powered on.  ***InvalidDatastore***: if the operation cannot be performed on the target datastores.  ***FileFault***: if there is an error accessing the virtual machine files.  ***InsufficientResourcesFault***: if this operation would violate a resource usage policy.  ***DisallowedMigrationDeviceAttached***: if any of the devices attached to the source virtual machine are not supported for the Instant Clone operation or if device change specification contains changes that are not supported.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinemakeprimaryvmtask"></a>
# **VirtualMachineMakePrimaryVMTask**
> ManagedObjectReference VirtualMachineMakePrimaryVMTask (string moId, MakePrimaryVMRequestType makePrimaryVMRequestType)

Makes the specified secondary virtual machine from this fault tolerant group as the primary virtual machine. 

Makes the specified secondary virtual machine from this fault tolerant group as the primary virtual machine.  ***Required privileges:*** VirtualMachine.Interact.MakePrimary 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineMakePrimaryVMTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var makePrimaryVMRequestType = new MakePrimaryVMRequestType(); // MakePrimaryVMRequestType | 

            try
            {
                // Makes the specified secondary virtual machine from this fault tolerant group as the primary virtual machine. 
                ManagedObjectReference result = apiInstance.VirtualMachineMakePrimaryVMTask(moId, makePrimaryVMRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineMakePrimaryVMTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineMakePrimaryVMTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Makes the specified secondary virtual machine from this fault tolerant group as the primary virtual machine. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineMakePrimaryVMTaskWithHttpInfo(moId, makePrimaryVMRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineMakePrimaryVMTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **makePrimaryVMRequestType** | [**MakePrimaryVMRequestType**](MakePrimaryVMRequestType.md) |  |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation.  Refers instance of *Task*.  |  -  |
| **500** | ***VmFaultToleranceIssue***: if any error is encountered with the fault tolerance configuration of the virtual machine. Typically, a more specific fault like InvalidOperationOnSecondaryVm is thrown.  ***TaskInProgress***: if the virtual machine is busy.  ***InvalidState***: if the host is in maintenance mode or if the virtual machine&#39;s configuration information is not available.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinemarkastemplate"></a>
# **VirtualMachineMarkAsTemplate**
> void VirtualMachineMarkAsTemplate (string moId)

Marks a VirtualMachine object as being used as a template. 

Marks a VirtualMachine object as being used as a template.  Note: A VirtualMachine marked as a template cannot be powered on.  ***Required privileges:*** VirtualMachine.Provisioning.MarkAsTemplate 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineMarkAsTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Marks a VirtualMachine object as being used as a template. 
                apiInstance.VirtualMachineMarkAsTemplate(moId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineMarkAsTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineMarkAsTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Marks a VirtualMachine object as being used as a template. 
    apiInstance.VirtualMachineMarkAsTemplateWithHttpInfo(moId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineMarkAsTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

void (empty response body)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content  |  -  |
| **500** | ***NotSupported***: if marking a virtual machine as a template is not supported.  ***InvalidPowerState***: if the virtual machine is not powered off.  ***InvalidState***: if the operation cannot be performed because of the virtual machine&#39;s current state. For example, if the virtual machine configuration information is not available.  ***VmConfigFault***: if the template is incompatible with the host, such as the files are not accessible.  ***FileFault***: if there is an error accessing the virtual machine files.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinemarkasvirtualmachine"></a>
# **VirtualMachineMarkAsVirtualMachine**
> void VirtualMachineMarkAsVirtualMachine (string moId, MarkAsVirtualMachineRequestType markAsVirtualMachineRequestType)

Clears the 'isTemplate' flag and reassociates the virtual machine with a resource pool and host. 

Clears the 'isTemplate' flag and reassociates the virtual machine with a resource pool and host.  ***Required privileges:*** VirtualMachine.Provisioning.MarkAsVM 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineMarkAsVirtualMachineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var markAsVirtualMachineRequestType = new MarkAsVirtualMachineRequestType(); // MarkAsVirtualMachineRequestType | 

            try
            {
                // Clears the 'isTemplate' flag and reassociates the virtual machine with a resource pool and host. 
                apiInstance.VirtualMachineMarkAsVirtualMachine(moId, markAsVirtualMachineRequestType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineMarkAsVirtualMachine: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineMarkAsVirtualMachineWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Clears the 'isTemplate' flag and reassociates the virtual machine with a resource pool and host. 
    apiInstance.VirtualMachineMarkAsVirtualMachineWithHttpInfo(moId, markAsVirtualMachineRequestType);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineMarkAsVirtualMachineWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **markAsVirtualMachineRequestType** | [**MarkAsVirtualMachineRequestType**](MarkAsVirtualMachineRequestType.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content  |  -  |
| **500** | ***NotSupported***: if marking a template as a virtual machine is not supported.  ***InvalidState***: if the virtual machine is not marked as a template.  ***InvalidDatastore***: if the operation cannot be performed on the target datastores.  ***VmConfigFault***: if the virtual machine is not compatible with the host. For example, a DisksNotSupported fault if the destination host does not support the disk backings of the template.  ***FileFault***: if there is an error accessing the virtual machine files.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinemigratevmtask"></a>
# **VirtualMachineMigrateVMTask**
> ManagedObjectReference VirtualMachineMigrateVMTask (string moId, MigrateVMRequestType migrateVMRequestType)

Migrates a virtual machine's execution to a specific resource pool or host. 

Deprecated as of vSphere 6.5, use *VirtualMachine.RelocateVM_Task* instead.  Migrates a virtual machine's execution to a specific resource pool or host.  Requires Resource.HotMigrate privilege if the virtual machine is powered on or Resource.ColdMigrate privilege if the virtual machine is powered off or suspended. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineMigrateVMTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var migrateVMRequestType = new MigrateVMRequestType(); // MigrateVMRequestType | 

            try
            {
                // Migrates a virtual machine's execution to a specific resource pool or host. 
                ManagedObjectReference result = apiInstance.VirtualMachineMigrateVMTask(moId, migrateVMRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineMigrateVMTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineMigrateVMTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Migrates a virtual machine's execution to a specific resource pool or host. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineMigrateVMTaskWithHttpInfo(moId, migrateVMRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineMigrateVMTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **migrateVMRequestType** | [**MigrateVMRequestType**](MigrateVMRequestType.md) |  |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation.  Refers instance of *Task*.  |  -  |
| **500** | ***NotSupported***: if the virtual machine is marked as a template.  ***InvalidArgument***: in the following cases: - the target host and target pool are not associated with the   same compute resource - the host parameter is left unset when the target pool is   associated with a non-DRS cluster    ***InvalidPowerState***: if the state argument is set and the virtual machine does not have that power state.  ***FileFault***: if, in a case where the virtual machine configuration file must be copied, the destination location for that file does not have the necessary file access permissions.  ***VmConfigFault***: if the virtual machine is not compatible with the destination host. Typically, a specific subclass of this exception is thrown, such as IDEDiskNotSupported.  ***MigrationFault***: if it is not possible to migrate the virtual machine to the destination host. This is typically due to hosts being incompatible, such as mismatch in network polices or access to networks and datastores. Typically, a more specific subclass is thrown.  ***Timedout***: if one of the phases of the migration process times out.  ***InsufficientResourcesFault***: if this operation would violate a resource usage policy.  ***InvalidState***: if the operation cannot be performed because of the virtual machine&#39;s current state or the target host&#39;s current state. For example, if the virtual machine configuration information is not available or if the target host is disconnected or in maintenance mode.  ***NoActiveHostInCluster***: if a target host is not specified and the cluster associated with the target pool does not contain at least one potential target host. A host must be connected and not in maintenance mode in order to be considered as a potential target host.  ***NoPermission***: if the virtual machine is encrypted, but encryption is not enabled on the destination host and the user does not have Cryptographer.RegisterHost permission on it.  ***NoPermission***: if the virtual machine is encrypted, but the the user does not have Cryptographer.Migrate permission on the VM.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinemounttoolsinstaller"></a>
# **VirtualMachineMountToolsInstaller**
> void VirtualMachineMountToolsInstaller (string moId)

Mounts the VMware Tools CD installer as a CD-ROM for the guest operating system. 

Mounts the VMware Tools CD installer as a CD-ROM for the guest operating system.  To monitor the status of the tools install, clients should check the tools status, *GuestInfo.toolsVersionStatus* and *GuestInfo.toolsRunningStatus*  ***Required privileges:*** VirtualMachine.Interact.ToolsInstall 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineMountToolsInstallerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Mounts the VMware Tools CD installer as a CD-ROM for the guest operating system. 
                apiInstance.VirtualMachineMountToolsInstaller(moId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineMountToolsInstaller: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineMountToolsInstallerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Mounts the VMware Tools CD installer as a CD-ROM for the guest operating system. 
    apiInstance.VirtualMachineMountToolsInstallerWithHttpInfo(moId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineMountToolsInstallerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

void (empty response body)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content  |  -  |
| **500** | ***InvalidState***: if the virtual machine is not running, or the VMware Tools CD is already mounted.  ***VmToolsUpgradeFault***: if the VMware Tools CD failed to mount.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinepoweroffvmtask"></a>
# **VirtualMachinePowerOffVMTask**
> ManagedObjectReference VirtualMachinePowerOffVMTask (string moId)

Powers off this virtual machine. 

Powers off this virtual machine.  If this virtual machine is a fault tolerant primary virtual machine, this will result in the secondary virtual machine(s) getting powered off as well.  ***Required privileges:*** VirtualMachine.Interact.PowerOff 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachinePowerOffVMTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Powers off this virtual machine. 
                ManagedObjectReference result = apiInstance.VirtualMachinePowerOffVMTask(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachinePowerOffVMTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachinePowerOffVMTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Powers off this virtual machine. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachinePowerOffVMTaskWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachinePowerOffVMTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation.  Refers instance of *Task*.  |  -  |
| **500** | ***InvalidPowerState***: if the power state is not poweredOn.  ***TaskInProgress***: if the virtual machine is busy.  ***NotSupported***: if the virtual machine is marked as a template.  ***InvalidState***: if the operation cannot be performed because of the virtual machine&#39;s current state. For example, if the virtual machine configuration information is not available.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinepoweronvmtask"></a>
# **VirtualMachinePowerOnVMTask**
> ManagedObjectReference VirtualMachinePowerOnVMTask (string moId, PowerOnVMRequestType? powerOnVMRequestType = null)

Powers on this virtual machine. 

Powers on this virtual machine.  If the virtual machine is suspended, this method resumes execution from the suspend point.  When powering on a virtual machine in a cluster, the system might implicitly or due to the host argument, do an implicit relocation of the virtual machine to another host. Hence, errors related to this relocation can be thrown. If the cluster is a DRS cluster, DRS will be invoked if the virtual machine can be automatically placed by DRS (see *DrsBehavior_enum*). Because this method does not return a DRS *ClusterRecommendation*, no vmotion nor host power operations will be done as part of a DRS-facilitated power on. To have DRS consider such operations use *Datacenter.PowerOnMultiVM_Task*. As of vSphere API 5.1, use of this method with vCenter Server is deprecated; use *Datacenter.PowerOnMultiVM_Task* instead.  If this virtual machine is a fault tolerant primary virtual machine, its secondary virtual machines will be started on system-selected hosts. If the virtual machines are in a VMware DRS enabled cluster, then DRS will be invoked to obtain placements for the secondaries but no vmotion nor host power operations will be considered for these power ons.  ***Required privileges:*** VirtualMachine.Interact.PowerOn 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachinePowerOnVMTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var powerOnVMRequestType = new PowerOnVMRequestType?(); // PowerOnVMRequestType? |  (optional) 

            try
            {
                // Powers on this virtual machine. 
                ManagedObjectReference result = apiInstance.VirtualMachinePowerOnVMTask(moId, powerOnVMRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachinePowerOnVMTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachinePowerOnVMTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Powers on this virtual machine. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachinePowerOnVMTaskWithHttpInfo(moId, powerOnVMRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachinePowerOnVMTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **powerOnVMRequestType** | [**PowerOnVMRequestType?**](PowerOnVMRequestType?.md) |  | [optional]  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation.  Refers instance of *Task*.  |  -  |
| **500** | ***InvalidPowerState***: if the power state is poweredOn.  ***TaskInProgress***: if the virtual machine is busy.  ***NotEnoughLicenses***: if there are not enough licenses to power on this virtual machine.  ***NotSupported***: if the virtual machine is marked as a template.  ***InvalidState***: if the host is in maintenance mode or if the virtual machine&#39;s configuration information is not available or if the virtual machine is already powering on  ***InsufficientResourcesFault***: if this operation would violate a resource usage policy.  ***VmConfigFault***: if a configuration issue prevents the power-on. Typically, a more specific fault, such as UnsupportedVmxLocation, is thrown.  ***FileFault***: if there is a problem accessing the virtual machine on the filesystem.  ***DisallowedOperationOnFailoverHost***: if the host specified is a failover host. See *ClusterFailoverHostAdmissionControlPolicy*.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinepromotediskstask"></a>
# **VirtualMachinePromoteDisksTask**
> ManagedObjectReference VirtualMachinePromoteDisksTask (string moId, PromoteDisksRequestType promoteDisksRequestType)

Promotes disks on this virtual machine that have delta disk backings. 

Promotes disks on this virtual machine that have delta disk backings.  A delta disk backing is a way to preserve a virtual disk backing at some point in time. A delta disk backing is a file backing which in turn points to the original virtual disk backing (the parent). After a delta disk backing is added, all writes go to the delta disk backing. All reads first try the delta disk backing and then try the parent backing if needed.  Promoting does two things 1. Unlinking shared disk backings:    All shared disk backings are copied from its parent to its home    directory. This creates an exclusive, unshared version for the VM disks    and removes the link to its parent from the delta disk, resulting in    the creation of an independent VM with its own base disk. 2. Consolidation:    Any disk backing which is not shared between multiple virtual    machines and is not associated with a snapshot is consolidated    with its child backing.     This operation is only supported if *HostCapability.deltaDiskBackingsSupported* is true.  This operation is only supported on VirtualCenter. If no work is required, an invocation completes successfully.  ***Required privileges:*** VirtualMachine.Provisioning.PromoteDisks 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachinePromoteDisksTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var promoteDisksRequestType = new PromoteDisksRequestType(); // PromoteDisksRequestType | 

            try
            {
                // Promotes disks on this virtual machine that have delta disk backings. 
                ManagedObjectReference result = apiInstance.VirtualMachinePromoteDisksTask(moId, promoteDisksRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachinePromoteDisksTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachinePromoteDisksTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Promotes disks on this virtual machine that have delta disk backings. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachinePromoteDisksTaskWithHttpInfo(moId, promoteDisksRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachinePromoteDisksTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **promoteDisksRequestType** | [**PromoteDisksRequestType**](PromoteDisksRequestType.md) |  |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Refers instance of *Task*.  |  -  |
| **500** | ***TaskInProgress***: if the virtual machine is busy.  ***NotSupported***: if the host doesn&#39;t support disk promotion APIs.  ***InvalidState***: if the virtual machine&#39;s power state changes during the execution of this method.  ***InvalidState***: if the virtual machine is not ready to respond to such requests.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachineputusbscancodes"></a>
# **VirtualMachinePutUsbScanCodes**
> int VirtualMachinePutUsbScanCodes (string moId, PutUsbScanCodesRequestType putUsbScanCodesRequestType)

Inject a sequence of USB HID scan codes into the keyboard. 

Inject a sequence of USB HID scan codes into the keyboard.  ***Required privileges:*** VirtualMachine.Interact.PutUsbScanCodes 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachinePutUsbScanCodesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var putUsbScanCodesRequestType = new PutUsbScanCodesRequestType(); // PutUsbScanCodesRequestType | 

            try
            {
                // Inject a sequence of USB HID scan codes into the keyboard. 
                int result = apiInstance.VirtualMachinePutUsbScanCodes(moId, putUsbScanCodesRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachinePutUsbScanCodes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachinePutUsbScanCodesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Inject a sequence of USB HID scan codes into the keyboard. 
    ApiResponse<int> response = apiInstance.VirtualMachinePutUsbScanCodesWithHttpInfo(moId, putUsbScanCodesRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachinePutUsbScanCodesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **putUsbScanCodesRequestType** | [**PutUsbScanCodesRequestType**](PutUsbScanCodesRequestType.md) |  |  |

### Return type

**int**

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Number of keys injected.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinequerychangeddiskareas"></a>
# **VirtualMachineQueryChangedDiskAreas**
> DiskChangeInfo VirtualMachineQueryChangedDiskAreas (string moId, QueryChangedDiskAreasRequestType queryChangedDiskAreasRequestType)

Get a list of areas of a virtual disk belonging to this VM that have been modified since a well-defined point in the past. 

Get a list of areas of a virtual disk belonging to this VM that have been modified since a well-defined point in the past.  The beginning of the change interval is identified by \"changeId\", while the end of the change interval is implied by the snapshot ID passed in.  Note that the result of this function may contain \"false positives\" (i.e: flag areas of the disk as modified that are not). However, it is guaranteed that no changes will be missed.  ***Required privileges:*** VirtualMachine.Provisioning.DiskRandomRead 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineQueryChangedDiskAreasExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var queryChangedDiskAreasRequestType = new QueryChangedDiskAreasRequestType(); // QueryChangedDiskAreasRequestType | 

            try
            {
                // Get a list of areas of a virtual disk belonging to this VM that have been modified since a well-defined point in the past. 
                DiskChangeInfo result = apiInstance.VirtualMachineQueryChangedDiskAreas(moId, queryChangedDiskAreasRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineQueryChangedDiskAreas: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineQueryChangedDiskAreasWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of areas of a virtual disk belonging to this VM that have been modified since a well-defined point in the past. 
    ApiResponse<DiskChangeInfo> response = apiInstance.VirtualMachineQueryChangedDiskAreasWithHttpInfo(moId, queryChangedDiskAreasRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineQueryChangedDiskAreasWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **queryChangedDiskAreasRequestType** | [**QueryChangedDiskAreasRequestType**](QueryChangedDiskAreasRequestType.md) |  |  |

### Return type

[**DiskChangeInfo**](DiskChangeInfo.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a data structure specifying extents of the virtual disk that have changed since the time the changeId string was obtained.  |  -  |
| **500** | ***NotFound***: if the snapshot specified does not exist.  ***InvalidArgument***: if deviceKey does not specify a virtual disk, startOffset is beyond the end of the virtual disk or changeId is invalid or change tracking is not supported for this particular disk.  ***FileFault***: if the virtual disk files cannot be accessed/queried.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinequeryconnections"></a>
# **VirtualMachineQueryConnections**
> List&lt;VirtualMachineConnection&gt; VirtualMachineQueryConnections (string moId)

Ask the virtual machine for a list of connections. 

Ask the virtual machine for a list of connections.  The virtual machine returns a list of connections. It is possible for the array returned to be empty - a virtual machine may have no connections.  ***Since:*** vSphere API Release 7.0.1.0  ***Required privileges:*** VirtualMachine.Interact.ConsoleInteract 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineQueryConnectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Ask the virtual machine for a list of connections. 
                List<VirtualMachineConnection> result = apiInstance.VirtualMachineQueryConnections(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineQueryConnections: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineQueryConnectionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Ask the virtual machine for a list of connections. 
    ApiResponse<List<VirtualMachineConnection>> response = apiInstance.VirtualMachineQueryConnectionsWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineQueryConnectionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**List&lt;VirtualMachineConnection&gt;**](VirtualMachineConnection.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |
| **500** | ***InvalidPowerState***: If the virtual machine is not powered on.  ***Timedout***: If the virtual machine did not respond to the request in a timely manner.  ***VmConfigFault***: If an error occurred.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinequeryfaulttolerancecompatibility"></a>
# **VirtualMachineQueryFaultToleranceCompatibility**
> List&lt;MethodFault&gt; VirtualMachineQueryFaultToleranceCompatibility (string moId)

This API can be invoked to determine whether a virtual machine is compatible for legacy Fault Tolerance. 

Deprecated as of vSphere API 6.0.  This API can be invoked to determine whether a virtual machine is compatible for legacy Fault Tolerance.  The API only checks for VM-specific factors that impact compatibility for RecordReplay based Fault Tolerance. Other requirements for Fault Tolerance such as host processor compatibility, logging nic configuration and licensing are not covered by this API. The query returns a list of faults, each fault corresponding to a specific incompatibility. If a given virtual machine is compatible for Fault Tolerance, then the fault list returned will be empty.  ***Required privileges:*** VirtualMachine.Config.QueryFTCompatibility 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineQueryFaultToleranceCompatibilityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // This API can be invoked to determine whether a virtual machine is compatible for legacy Fault Tolerance. 
                List<MethodFault> result = apiInstance.VirtualMachineQueryFaultToleranceCompatibility(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineQueryFaultToleranceCompatibility: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineQueryFaultToleranceCompatibilityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API can be invoked to determine whether a virtual machine is compatible for legacy Fault Tolerance. 
    ApiResponse<List<MethodFault>> response = apiInstance.VirtualMachineQueryFaultToleranceCompatibilityWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineQueryFaultToleranceCompatibilityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**List&lt;MethodFault&gt;**](MethodFault.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |
| **500** | ***InvalidState***: if the operation cannot be performed because of the virtual machine&#39;s current state.  ***VmConfigFault***: if the virtual machine&#39;s configuration is invalid.  ***NotSupported***: if the virtual machine is a template or this operation is not supported.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinequeryfaulttolerancecompatibilityex"></a>
# **VirtualMachineQueryFaultToleranceCompatibilityEx**
> List&lt;MethodFault&gt; VirtualMachineQueryFaultToleranceCompatibilityEx (string moId, QueryFaultToleranceCompatibilityExRequestType? queryFaultToleranceCompatibilityExRequestType = null)

This API can be invoked to determine whether a virtual machine is compatible for Fault Tolerance. 

This API can be invoked to determine whether a virtual machine is compatible for Fault Tolerance.  The API only checks for VM-specific factors that impact compatibility for Fault Tolerance. Other requirements for Fault Tolerance such as host processor compatibility, logging nic configuration and licensing are not covered by this API. The query returns a list of faults, each fault corresponding to a specific incompatibility. If a given virtual machine is compatible for Fault Tolerance, then the fault list returned will be empty.  ***Required privileges:*** VirtualMachine.Config.QueryFTCompatibility 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineQueryFaultToleranceCompatibilityExExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var queryFaultToleranceCompatibilityExRequestType = new QueryFaultToleranceCompatibilityExRequestType?(); // QueryFaultToleranceCompatibilityExRequestType? |  (optional) 

            try
            {
                // This API can be invoked to determine whether a virtual machine is compatible for Fault Tolerance. 
                List<MethodFault> result = apiInstance.VirtualMachineQueryFaultToleranceCompatibilityEx(moId, queryFaultToleranceCompatibilityExRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineQueryFaultToleranceCompatibilityEx: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineQueryFaultToleranceCompatibilityExWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API can be invoked to determine whether a virtual machine is compatible for Fault Tolerance. 
    ApiResponse<List<MethodFault>> response = apiInstance.VirtualMachineQueryFaultToleranceCompatibilityExWithHttpInfo(moId, queryFaultToleranceCompatibilityExRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineQueryFaultToleranceCompatibilityExWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **queryFaultToleranceCompatibilityExRequestType** | [**QueryFaultToleranceCompatibilityExRequestType?**](QueryFaultToleranceCompatibilityExRequestType?.md) |  | [optional]  |

### Return type

[**List&lt;MethodFault&gt;**](MethodFault.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |
| **500** | ***InvalidState***: if the operation cannot be performed because of the virtual machine&#39;s current state.  ***VmConfigFault***: if the virtual machine&#39;s configuration is invalid.  ***NotSupported***: if the virtual machine is a template or this operation is not supported.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinequeryunownedfiles"></a>
# **VirtualMachineQueryUnownedFiles**
> List&lt;string&gt; VirtualMachineQueryUnownedFiles (string moId)

For all files that belong to the vm, check that the file owner is set to the current datastore principal user, as set by *HostDatastoreSystem.ConfigureDatastorePrincipal* 

For all files that belong to the vm, check that the file owner is set to the current datastore principal user, as set by *HostDatastoreSystem.ConfigureDatastorePrincipal*  ***Required privileges:*** VirtualMachine.Config.QueryUnownedFiles 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineQueryUnownedFilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // For all files that belong to the vm, check that the file owner is set to the current datastore principal user, as set by *HostDatastoreSystem.ConfigureDatastorePrincipal* 
                List<string> result = apiInstance.VirtualMachineQueryUnownedFiles(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineQueryUnownedFiles: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineQueryUnownedFilesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // For all files that belong to the vm, check that the file owner is set to the current datastore principal user, as set by *HostDatastoreSystem.ConfigureDatastorePrincipal* 
    ApiResponse<List<string>> response = apiInstance.VirtualMachineQueryUnownedFilesWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineQueryUnownedFilesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

**List<string>**

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of file paths for vm files whose ownership is not correct. Use *FileManager.ChangeOwner* to set the file ownership.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinerebootguest"></a>
# **VirtualMachineRebootGuest**
> void VirtualMachineRebootGuest (string moId)

Issues a command to the guest operating system asking it to perform a reboot. 

Issues a command to the guest operating system asking it to perform a reboot.  Returns immediately and does not wait for the guest operating system to complete the operation.  ***Required privileges:*** VirtualMachine.Interact.Reset 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineRebootGuestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Issues a command to the guest operating system asking it to perform a reboot. 
                apiInstance.VirtualMachineRebootGuest(moId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineRebootGuest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineRebootGuestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Issues a command to the guest operating system asking it to perform a reboot. 
    apiInstance.VirtualMachineRebootGuestWithHttpInfo(moId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineRebootGuestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

void (empty response body)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content  |  -  |
| **500** | ***InvalidPowerState***: if the power state is not powered on.  ***ToolsUnavailable***: if VMware Tools is not running.  ***TaskInProgress***: if the virtual machine is busy.  ***InvalidState***: if the operation cannot be performed because of the virtual machine&#39;s current state. For example, if the virtual machine configuration information is not available.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinereconfigvmtask"></a>
# **VirtualMachineReconfigVMTask**
> ManagedObjectReference VirtualMachineReconfigVMTask (string moId, ReconfigVMRequestType reconfigVMRequestType)

Reconfigures this virtual machine. 

Reconfigures this virtual machine.  All the changes in the given configuration are applied to the virtual machine as an atomic operation.  Reconfiguring the virtual machine may require any of the following privileges depending on what is being changed: - VirtualMachine.Interact.DeviceConnection if changing the runtime connection   state of a device as embodied by the Connectable property. - VirtualMachine.Interact.SetCDMedia if changing the backing of a CD-ROM   device - VirtualMachine.Interact.SetFloppyMedia if changing the backing of a   floppy device - VirtualMachine.Config.Rename if renaming the virtual machine - VirtualMachine.Config.Annotation if setting annotation a value - VirtualMachine.Config.AddExistingDisk if adding a virtual disk device   that is backed by an existing virtual disk file - VirtualMachine.Config.AddNewDisk if adding a virtual disk device for which   the backing virtual disk file is to be created - VirtualMachine.Config.RemoveDisk if removing a virtual disk device that   refers to a virtual disk file - VirtualMachine.Config.CPUCount if changing the number of CPUs - VirtualMachine.Config.Memory if changing the amount of memory - VirtualMachine.Config.RawDevice if adding, removing or editing a raw   device mapping (RDM) or SCSI passthrough device - VirtualMachine.Config.AddRemoveDevice if adding or removing any   device other than disk, raw, or USB device - VirtualMachine.Config.EditDevice if changing the settings of any   device - VirtualMachine.Config.Settings if changing any basic settings such as   those in ToolsConfigInfo, FlagInfo, or DefaultPowerOpInfo - VirtualMachine.Config.Resource if changing resource allocations,   affinities, or setting network traffic shaping or virtual disk shares - VirtualMachine.Config.AdvancedConfig if changing values in   extraConfig - VirtualMachine.Config.SwapPlacement if changing swapPlacement - VirtualMachine.Config.HostUSBDevice if adding, removing or editing a   VirtualUSB device backed by the host USB device. - VirtualMachine.Config.DiskExtend if extending an existing VirtualDisk   device. - VirtualMachine.Config.ChangeTracking if enabling/disabling changed   block tracking for the virtual machine's disks. - VirtualMachine.Config.MksControl if toggling display connection   limits or the guest auto-lock feature. - VirtualMachine.Config.ManagedBy if changing   *managedBy* property of the VM. - VirtualMachine.Config.UpgradeVirtualHardware if upgrading the VM's   virtual hardware to the latest revision that is supported by the VM's host. - Cryptographer.Encrypt if vm home folder is encrypted or existing   disk is encrypted. - Cryptographer.Decrypt if vm home folder is decrypted or existing   disk is decrypted. - Cryptographer.Recrypt if vm home folder is recrypted or existing   disk is recrypted. - Cryptographer.AddDisk if encrypted disk is attached to the vm. - Cryptographer.RegisterHost on the host if the virtual machine is   encrypted, but encryption is not enabled on the host.    Creating a virtual machine may require the following privileges: - VirtualMachine.Config.RawDevice if adding a raw device - VirtualMachine.Config.AddExistingDisk if adding a VirtualDisk and   the fileOperation is unset - VirtualMachine.Config.AddNewDisk if adding a VirtualDisk and   the fileOperation is set - VirtualMachine.Config.HostUSBDevice if adding a VirtualUSB device   backed by the host USB device.    In addition, this operation may require the following privileges: - Datastore.AllocateSpace on any datastore where virtual disks will   be created or extended. - Network.Assign on any network the virtual machine will be   connected to.    To create a VirtualDisk on a persistent memory storage, the storage must be specified via *profile* while the datastore property of corresponding VirtualDisk backing must be unset.  To create a VirtualNVDIMM device, the storage *profile* must be set to the default persistent memory storage profile while the datastore property of *the device backing* must be unset. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineReconfigVMTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var reconfigVMRequestType = new ReconfigVMRequestType(); // ReconfigVMRequestType | 

            try
            {
                // Reconfigures this virtual machine. 
                ManagedObjectReference result = apiInstance.VirtualMachineReconfigVMTask(moId, reconfigVMRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineReconfigVMTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineReconfigVMTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reconfigures this virtual machine. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineReconfigVMTaskWithHttpInfo(moId, reconfigVMRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineReconfigVMTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **reconfigVMRequestType** | [**ReconfigVMRequestType**](ReconfigVMRequestType.md) |  |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation.  Refers instance of *Task*.  |  -  |
| **500** | ***InvalidPowerState***: if the power state is poweredOn and the virtual hardware cannot support the configuration changes.  ***TaskInProgress***: if the virtual machine is busy.  ***TooManyDevices***: if the device specifications exceed the allowed limits.  ***ConcurrentAccess***: if the changeVersion does not match the server&#39;s changeVersion for the configuration.  ***FileFault***: if there is a problem creating or accessing the virtual machine&#39;s files for this operation. Typically a more specific fault like NoDiskSpace or FileAlreadyExists is thrown.  ***InvalidName***: if the specified name is invalid.  ***DuplicateName***: if the specified name already exists in the parent folder.  ***InvalidState***: if the operation cannot be performed in the current state of the virtual machine. For example, because the virtual machine&#39;s configuration is not available.  ***InsufficientResourcesFault***: if this operation would violate a resource usage policy.  ***VmConfigFault***: if the spec is invalid. Typically, a more specific subclass is thrown.  ***CpuHotPlugNotSupported***: if the current configuration of the VM does not support hot-plugging of CPUs.  ***MemoryHotPlugNotSupported***: if the current configuration of the VM does not support hot-plugging of memory.  ***VmWwnConflict***: if the WWN of the virtual machine has been used by other virtual machines.  ***NoPermission***: if crypto operation is requested on the vm home folder, but the user does not have the corresponding crypto privilege on the virtual machine: Encrypt - Cryptographer.Encrypt Decrypt - Cryptographer.Decrypt Recrypt - Cryptographer.Recrypt  ***NoPermission***: if crypto operation is requested on the vms disks, but the user does not have the corresponding crypto privilege on the virtual machine: Encrypt - Cryptographer.Encrypt Decrypt - Cryptographer.Decrypt Recrypt - Cryptographer.Recrypt AddDisk - Cryptographer.AddDisk  ***NoPermission***: if the virtual machine is encrypted and the encryption is not enabled on the host, but the user does not have Cryptographer.RegisterHost privilege on the host.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinerefreshstorageinfo"></a>
# **VirtualMachineRefreshStorageInfo**
> void VirtualMachineRefreshStorageInfo (string moId)

Explicitly refreshes the storage information of this virtual machine, updating properties *VirtualMachine.storage*, *VirtualMachine.layoutEx* and *VirtualMachineSummary.storage*. 

Explicitly refreshes the storage information of this virtual machine, updating properties *VirtualMachine.storage*, *VirtualMachine.layoutEx* and *VirtualMachineSummary.storage*.  This is an asynchronous operation which will return immediately; changes may not be reflected in vCenter for some time.  ***Required privileges:*** System.Read 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineRefreshStorageInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Explicitly refreshes the storage information of this virtual machine, updating properties *VirtualMachine.storage*, *VirtualMachine.layoutEx* and *VirtualMachineSummary.storage*. 
                apiInstance.VirtualMachineRefreshStorageInfo(moId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineRefreshStorageInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineRefreshStorageInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Explicitly refreshes the storage information of this virtual machine, updating properties *VirtualMachine.storage*, *VirtualMachine.layoutEx* and *VirtualMachineSummary.storage*. 
    apiInstance.VirtualMachineRefreshStorageInfoWithHttpInfo(moId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineRefreshStorageInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

void (empty response body)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinereload"></a>
# **VirtualMachineReload**
> void VirtualMachineReload (string moId)

Reload the entity state. 

Reload the entity state.  Clients only need to call this method if they changed some external state that affects the service without using the Web service interface to perform the change. For example, hand-editing a virtual machine configuration file affects the configuration of the associated virtual machine but the service managing the virtual machine might not monitor the file for changes. In this case, after such an edit, a client would call \"reload\" on the associated virtual machine to ensure the service and its clients have current data for the virtual machine.  ***Required privileges:*** System.Read 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineReloadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Reload the entity state. 
                apiInstance.VirtualMachineReload(moId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineReload: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineReloadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reload the entity state. 
    apiInstance.VirtualMachineReloadWithHttpInfo(moId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineReloadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

void (empty response body)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinereloadvirtualmachinefrompathtask"></a>
# **VirtualMachineReloadVirtualMachineFromPathTask**
> ManagedObjectReference VirtualMachineReloadVirtualMachineFromPathTask (string moId, ReloadVirtualMachineFromPathRequestType reloadVirtualMachineFromPathRequestType)

Reloads the configuration for this virtual machine from a given datastore path. 

Reloads the configuration for this virtual machine from a given datastore path.  This is equivalent to unregistering and registering the virtual machine from a different path. The virtual machine's hardware configuration, snapshots, guestinfo variables etc. will be replaced based on the new configuration file. Other information associated with the virtual machine object, such as events and permissions, will be preserved.  This method is only supported on vCenter Server. It can be invoked on inaccessible or orphaned virtual machines, but it cannot be invoked on powered on, connected virtual machines. Both the source virtual machine object and the destination path should be of the same type i.e. virtual machine or template. Reloading a virtual machine with a template or vice-versa is not supported.  _Note:_ Since the API replaces the source configuration with that of the destination, if the destination configuration does not refer to a valid virtual machine, it will create an invalid virtual machine object. This API should not be invoked on fault tolerant virtual machines since doing so will leave the original virtual machine's configuration in an invalid state. It is recommended that you turn off fault tolerance before invoking this API.  ***Required privileges:*** VirtualMachine.Config.ReloadFromPath 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineReloadVirtualMachineFromPathTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var reloadVirtualMachineFromPathRequestType = new ReloadVirtualMachineFromPathRequestType(); // ReloadVirtualMachineFromPathRequestType | 

            try
            {
                // Reloads the configuration for this virtual machine from a given datastore path. 
                ManagedObjectReference result = apiInstance.VirtualMachineReloadVirtualMachineFromPathTask(moId, reloadVirtualMachineFromPathRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineReloadVirtualMachineFromPathTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineReloadVirtualMachineFromPathTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reloads the configuration for this virtual machine from a given datastore path. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineReloadVirtualMachineFromPathTaskWithHttpInfo(moId, reloadVirtualMachineFromPathRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineReloadVirtualMachineFromPathTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **reloadVirtualMachineFromPathRequestType** | [**ReloadVirtualMachineFromPathRequestType**](ReloadVirtualMachineFromPathRequestType.md) |  |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Refers instance of *Task*.  |  -  |
| **500** | ***NotSupported***: if invoked on ESX server or if invoked on a virtual machine with the destination path for a template and vice-versa.  ***InvalidPowerState***: if the virtual machine is powered on.  ***TaskInProgress***: if the virtual machine is busy.  ***FileFault***: if there is a problem creating or accessing the files needed for this operation.  ***InvalidState***: if the virtual machine is busy or not ready to respond to such requests.  ***VmConfigFault***: if the format / configuration of the virtual machine is invalid. Typically, a more specific fault is thrown such as InvalidFormat if the configuration file cannot be read, or InvalidDiskFormat if the disks cannot be read.  ***AlreadyExists***: if the virtual machine is already registered.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinerelocatevmtask"></a>
# **VirtualMachineRelocateVMTask**
> ManagedObjectReference VirtualMachineRelocateVMTask (string moId, RelocateVMRequestType relocateVMRequestType)

Relocates a virtual machine to the location specified by *VirtualMachineRelocateSpec*. 

Relocates a virtual machine to the location specified by *VirtualMachineRelocateSpec*.  Starting from VCenter 5.1, this API also supports relocating a template to a new host should the current host become inactive. Starting from vCenter 6.0 this API also supports relocating a VM to a new vCenter service.  Requires the following additional privileges: - Resource.HotMigrate if the virtual machine is powered on. - Datastore.AllocateSpace if the virtual machine or its disks are   being relocated to a new datastore. - Starting from vSphere 9.0, Cryptographer.Access is required if the   virtual machine is encrypted and the virtual machine or its disks   are being relocated to a new datastore. - Resource.AssignVMToPool if the resource pool is changing. - VirtualMachine.Inventory.Register against the destination folder if   the virtual machine is moving to a new vCenter service. - VirtualMachine.Inventory.Move against the virtual machine, source   folder, and destination folder if the virtual machine is changing   folders within the same vCenter service. - Network.Assign against the new network if the virtual machine is   changing networks.    If this virtual machine is configured with a VirtualNVDIMM device, and if the virtual machine will be moved to a different host, the VirtualNVDIMM will be automatically relocated to the destination host's Non-Volatile Memory storage. If this Virtual machine is configured with virtual disks via persistent memory storage profile: - If spec specifies only compute location change, these virtual disks   will be automatically moved to a persistent memory storage in   destination host that supports the profile. - If spec specifies primary datastore change via   *datastore*, unlike regular   virtual disks, these disks will not be automatically moved to the   specified datastore, instead they will stay on a persistent   memory storage in destination host that supports the profile. - To explicitly move these disks to a location other than   persistent memory storage, use disk locator to specify the   new destination datastore along with a storage profile that removes   the persistent memory storage requirement. Note that this   downgrades the disk I/O performance. - On the other hand, to move a virtual disk from a regular storage to   persistent memory, use   *deviceChange*   to specify a storage profile of persistent memory storage. Note   that this upgrades the disk I/O performance.    ***Required privileges:*** Resource.ColdMigrate 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineRelocateVMTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var relocateVMRequestType = new RelocateVMRequestType(); // RelocateVMRequestType | 

            try
            {
                // Relocates a virtual machine to the location specified by *VirtualMachineRelocateSpec*. 
                ManagedObjectReference result = apiInstance.VirtualMachineRelocateVMTask(moId, relocateVMRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineRelocateVMTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineRelocateVMTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Relocates a virtual machine to the location specified by *VirtualMachineRelocateSpec*. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineRelocateVMTaskWithHttpInfo(moId, relocateVMRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineRelocateVMTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **relocateVMRequestType** | [**RelocateVMRequestType**](RelocateVMRequestType.md) |  |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation.  Refers instance of *Task*.  |  -  |
| **500** | ***InvalidArgument***: in the following cases: - the target host and target pool are not associated with the   same compute resource - the target pool represents a cluster without DRS enabled,   and the host is not specified - the virtual machine is powered on, its home or any of its disks   will change storage location, and the host is not specified - Datastore is not accessible in a cross-datacenter move - Datastore in a diskLocator entry is not specified - the specified device ID cannot be found in the virtual machine&#39;s current   configuration    ***NotSupported***: if the virtual machine is marked as template and the datastore is changing or if it is a cross vCenter vMotion operation.  ***Timedout***: if one of the phases of the relocate process times out.  ***InvalidState***: if the operation cannot be performed because of the host or virtual machine&#39;s current state. For example, if the host is in maintenance mode, or if the virtual machine&#39;s configuration information is not available.  ***InvalidDatastore***: if the operation cannot be performed on the target datastores.  ***FileFault***: if there is an error accessing the virtual machine files.  ***VmConfigFault***: if the virtual machine is not compatible with the destination host. Typically, a specific subclass of this exception is thrown, such as IDEDiskNotSupported.  ***MigrationFault***: if it is not possible to migrate the virtual machine to the destination host. This is typically due to hosts being incompatible, such as mismatch in network polices or access to networks and datastores. Typically, a more specific subclass is thrown.  ***InsufficientResourcesFault***: if this operation would violate a resource usage policy.  ***DisallowedOperationOnFailoverHost***: if the virtual machine is powered on and is being migrated to a failover host. See *ClusterFailoverHostAdmissionControlPolicy*.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachineremoveallsnapshotstask"></a>
# **VirtualMachineRemoveAllSnapshotsTask**
> ManagedObjectReference VirtualMachineRemoveAllSnapshotsTask (string moId, RemoveAllSnapshotsRequestType? removeAllSnapshotsRequestType = null)

Remove all the snapshots associated with this virtual machine. 

Remove all the snapshots associated with this virtual machine.  If the virtual machine does not have any snapshots, then this operation simply returns successfully.  ***Required privileges:*** VirtualMachine.State.RemoveSnapshot 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineRemoveAllSnapshotsTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var removeAllSnapshotsRequestType = new RemoveAllSnapshotsRequestType?(); // RemoveAllSnapshotsRequestType? |  (optional) 

            try
            {
                // Remove all the snapshots associated with this virtual machine. 
                ManagedObjectReference result = apiInstance.VirtualMachineRemoveAllSnapshotsTask(moId, removeAllSnapshotsRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineRemoveAllSnapshotsTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineRemoveAllSnapshotsTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove all the snapshots associated with this virtual machine. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineRemoveAllSnapshotsTaskWithHttpInfo(moId, removeAllSnapshotsRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineRemoveAllSnapshotsTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **removeAllSnapshotsRequestType** | [**RemoveAllSnapshotsRequestType?**](RemoveAllSnapshotsRequestType?.md) |  | [optional]  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation.  Refers instance of *Task*.  |  -  |
| **500** | ***TaskInProgress***: if the virtual machine is busy.  ***NotSupported***: if the host product does not support snapshots.  ***InvalidPowerState***: if the operation cannot be performed in the current power state of the virtual machine.  ***SnapshotFault***: if an error occurs during the snapshot operation. Typically, a more specific fault like InvalidSnapshotFormat is thrown.  ***InvalidState***: if the operation cannot be performed because of the virtual machine&#39;s current state. For example, if the virtual machine configuration information is not available.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinerenametask"></a>
# **VirtualMachineRenameTask**
> ManagedObjectReference VirtualMachineRenameTask (string moId, RenameRequestType renameRequestType)

Renames this managed entity. 

Renames this managed entity.  Any % (percent) character used in this name parameter must be escaped, unless it is used to start an escape sequence. Clients may also escape any other characters in this name parameter.  See also *ManagedEntity.name*.  ***Required privileges:*** VirtualMachine.Config.Rename 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineRenameTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var renameRequestType = new RenameRequestType(); // RenameRequestType | 

            try
            {
                // Renames this managed entity. 
                ManagedObjectReference result = apiInstance.VirtualMachineRenameTask(moId, renameRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineRenameTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineRenameTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Renames this managed entity. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineRenameTaskWithHttpInfo(moId, renameRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineRenameTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **renameRequestType** | [**RenameRequestType**](RenameRequestType.md) |  |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation.  Refers instance of *Task*.  |  -  |
| **500** | ***DuplicateName***: If another object in the same folder has the target name.  ***InvalidName***: If the new name is not a valid entity name.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinerepairvmdiskchainstask"></a>
# **VirtualMachineRepairVmDiskChainsTask**
> ManagedObjectReference VirtualMachineRepairVmDiskChainsTask (string moId)

Repair the broken disk chains in the VM while the VM is powered off. 

Repair the broken disk chains in the VM while the VM is powered off.  Requires Datastore.FileManagement privilege on the datastore where each virtual disk resides.  ***Since:*** vSphere API Release 9.1.0.0 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineRepairVmDiskChainsTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Repair the broken disk chains in the VM while the VM is powered off. 
                ManagedObjectReference result = apiInstance.VirtualMachineRepairVmDiskChainsTask(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineRepairVmDiskChainsTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineRepairVmDiskChainsTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Repair the broken disk chains in the VM while the VM is powered off. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineRepairVmDiskChainsTaskWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineRepairVmDiskChainsTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Refers instance of *Task*.  |  -  |
| **500** | ***InvalidPowerState***: if the virtual machine is powered on or suspended.  ***VmConfigFault***: if a virtual machine configuration issue prevents repairing. Typically, a more specific fault is thrown such as *InvalidDiskFormat* if a disk cannot be read.  ***InsufficientResourcesFault***: if this operation would violate a resource usage policy. This is typically due to too many open files causing disk files cannot open.  ***FileFault***: if there is a problem accessing the virtual machine&#39;s disk files for this operation. Typically a more specific fault for example *NoDiskSpace* or *FileLocked* is thrown.  ***TaskInProgress***: if the virtual machine is busy.  ***NotSupported***: if the ESX server doesn&#39;t support repair of the VM  ***SystemError***: if failure due to any other reason.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachineresetguestinformation"></a>
# **VirtualMachineResetGuestInformation**
> void VirtualMachineResetGuestInformation (string moId)

Clears cached guest information. 

Clears cached guest information.  Guest information can be cleared only if the virtual machine is powered off.  This method can be useful if stale information is cached, preventing an IP address or MAC address from being reused.  ***Required privileges:*** VirtualMachine.Config.ResetGuestInfo 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineResetGuestInformationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Clears cached guest information. 
                apiInstance.VirtualMachineResetGuestInformation(moId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineResetGuestInformation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineResetGuestInformationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Clears cached guest information. 
    apiInstance.VirtualMachineResetGuestInformationWithHttpInfo(moId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineResetGuestInformationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

void (empty response body)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content  |  -  |
| **500** | ***InvalidState***: if the virtual machine is not powered off.  ***NotSupported***: if the virtual machine is marked as a template.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachineresetvmtask"></a>
# **VirtualMachineResetVMTask**
> ManagedObjectReference VirtualMachineResetVMTask (string moId)

Resets power on this virtual machine. 

Resets power on this virtual machine.  If the current state is poweredOn, then this method first performs powerOff(hard). Once the power state is poweredOff, then this method performs powerOn(option).  Although this method functions as a powerOff followed by a powerOn, the two operations are atomic with respect to other clients, meaning that other power operations cannot be performed until the reset method completes.  ***Required privileges:*** VirtualMachine.Interact.Reset 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineResetVMTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Resets power on this virtual machine. 
                ManagedObjectReference result = apiInstance.VirtualMachineResetVMTask(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineResetVMTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineResetVMTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Resets power on this virtual machine. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineResetVMTaskWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineResetVMTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation.  Refers instance of *Task*.  |  -  |
| **500** | ***InvalidPowerState***: if the power state is suspended or poweredOff.  ***TaskInProgress***: if the virtual machine is busy.  ***NotEnoughLicenses***: if there are not enough licenses to reset this virtual machine.  ***NotSupported***: if the virtual machine is marked as a template.  ***InvalidState***: if the host is in maintenance mode.  ***InvalidState***: if the operation cannot be performed because of the virtual machine&#39;s current state. For example, if the virtual machine configuration information is not available.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinereverttocurrentsnapshottask"></a>
# **VirtualMachineRevertToCurrentSnapshotTask**
> ManagedObjectReference VirtualMachineRevertToCurrentSnapshotTask (string moId, RevertToCurrentSnapshotRequestType? revertToCurrentSnapshotRequestType = null)

Reverts the virtual machine to the current snapshot. 

Reverts the virtual machine to the current snapshot.  This is equivalent to doing snapshot.currentSnapshot.revert.  If no snapshot exists, then the operation does nothing, and the virtual machine state remains unchanged.  ***Required privileges:*** VirtualMachine.State.RevertToSnapshot 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineRevertToCurrentSnapshotTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var revertToCurrentSnapshotRequestType = new RevertToCurrentSnapshotRequestType?(); // RevertToCurrentSnapshotRequestType? |  (optional) 

            try
            {
                // Reverts the virtual machine to the current snapshot. 
                ManagedObjectReference result = apiInstance.VirtualMachineRevertToCurrentSnapshotTask(moId, revertToCurrentSnapshotRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineRevertToCurrentSnapshotTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineRevertToCurrentSnapshotTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reverts the virtual machine to the current snapshot. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineRevertToCurrentSnapshotTaskWithHttpInfo(moId, revertToCurrentSnapshotRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineRevertToCurrentSnapshotTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **revertToCurrentSnapshotRequestType** | [**RevertToCurrentSnapshotRequestType?**](RevertToCurrentSnapshotRequestType?.md) |  | [optional]  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation.  Refers instance of *Task*.  |  -  |
| **500** | ***TaskInProgress***: if the virtual machine is busy.  ***NotSupported***: if the host product does not support snapshots.  ***InsufficientResourcesFault***: if this operation would violate a resource usage policy.  ***SnapshotFault***: if an error occurs during the snapshot operation. Typically, a more specific fault like InvalidSnapshotFormat is thrown.  ***InvalidPowerState***: if the operation cannot be performed in the current power state of the virtual machine.  ***InvalidState***: if the operation cannot be performed because of the virtual machine&#39;s current state. For example, if the virtual machine configuration information is not available or if an OVF consumer is blocking the operation.  ***VmConfigFault***: if a configuration issue prevents the power-on. Typically, a more specific fault, such as UnsupportedVmxLocation, is thrown.  ***FileFault***: if there is a problem accessing the virtual machine on the filesystem.  ***NotFound***: if the virtual machine does not have a current snapshot.  ***DisallowedOperationOnFailoverHost***: if the virtual machine is being reverted to a powered on state and the host specified is a failover host. See *ClusterFailoverHostAdmissionControlPolicy*.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinesendnmi"></a>
# **VirtualMachineSendNMI**
> void VirtualMachineSendNMI (string moId)

Send a non-maskable interrupt (NMI). 

Send a non-maskable interrupt (NMI).  Currently, there is no way to verify if the NMI was actually received by the guest OS.  ***Required privileges:*** VirtualMachine.Interact.GuestControl 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineSendNMIExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Send a non-maskable interrupt (NMI). 
                apiInstance.VirtualMachineSendNMI(moId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineSendNMI: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineSendNMIWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send a non-maskable interrupt (NMI). 
    apiInstance.VirtualMachineSendNMIWithHttpInfo(moId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineSendNMIWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

void (empty response body)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content  |  -  |
| **500** | ***InvalidState***: if the virtual machine is not powered on.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinesetcustomvalue"></a>
# **VirtualMachineSetCustomValue**
> void VirtualMachineSetCustomValue (string moId, SetCustomValueRequestType setCustomValueRequestType)

Assigns a value to a custom field. 

Assigns a value to a custom field.  The setCustomValue method requires whichever updatePrivilege is defined as one of the *CustomFieldDef.fieldInstancePrivileges* for the CustomFieldDef whose value is being changed. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineSetCustomValueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var setCustomValueRequestType = new SetCustomValueRequestType(); // SetCustomValueRequestType | 

            try
            {
                // Assigns a value to a custom field. 
                apiInstance.VirtualMachineSetCustomValue(moId, setCustomValueRequestType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineSetCustomValue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineSetCustomValueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Assigns a value to a custom field. 
    apiInstance.VirtualMachineSetCustomValueWithHttpInfo(moId, setCustomValueRequestType);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineSetCustomValueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **setCustomValueRequestType** | [**SetCustomValueRequestType**](SetCustomValueRequestType.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinesetdisplaytopology"></a>
# **VirtualMachineSetDisplayTopology**
> void VirtualMachineSetDisplayTopology (string moId, SetDisplayTopologyRequestType setDisplayTopologyRequestType)

Sets the console window's display topology as specified. 

Sets the console window's display topology as specified.  ***Required privileges:*** VirtualMachine.Interact.ConsoleInteract 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineSetDisplayTopologyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var setDisplayTopologyRequestType = new SetDisplayTopologyRequestType(); // SetDisplayTopologyRequestType | 

            try
            {
                // Sets the console window's display topology as specified. 
                apiInstance.VirtualMachineSetDisplayTopology(moId, setDisplayTopologyRequestType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineSetDisplayTopology: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineSetDisplayTopologyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sets the console window's display topology as specified. 
    apiInstance.VirtualMachineSetDisplayTopologyWithHttpInfo(moId, setDisplayTopologyRequestType);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineSetDisplayTopologyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **setDisplayTopologyRequestType** | [**SetDisplayTopologyRequestType**](SetDisplayTopologyRequestType.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content  |  -  |
| **500** | ***NotSupported***: if the Guest Operating system does not support setting the display topology  ***InvalidPowerState***: if the power state is not poweredOn.  ***InvalidState***: if the virtual machine is not connected.  ***ToolsUnavailable***: if VMware Tools is not running.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinesetscreenresolution"></a>
# **VirtualMachineSetScreenResolution**
> void VirtualMachineSetScreenResolution (string moId, SetScreenResolutionRequestType setScreenResolutionRequestType)

Sets the console window's resolution as specified. 

Sets the console window's resolution as specified.  ***Required privileges:*** VirtualMachine.Interact.ConsoleInteract 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineSetScreenResolutionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var setScreenResolutionRequestType = new SetScreenResolutionRequestType(); // SetScreenResolutionRequestType | 

            try
            {
                // Sets the console window's resolution as specified. 
                apiInstance.VirtualMachineSetScreenResolution(moId, setScreenResolutionRequestType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineSetScreenResolution: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineSetScreenResolutionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sets the console window's resolution as specified. 
    apiInstance.VirtualMachineSetScreenResolutionWithHttpInfo(moId, setScreenResolutionRequestType);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineSetScreenResolutionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **setScreenResolutionRequestType** | [**SetScreenResolutionRequestType**](SetScreenResolutionRequestType.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content  |  -  |
| **500** | ***NotSupported***: if the Guest Operating system does not support setting the screen resolution.  ***InvalidPowerState***: if the power state is not poweredOn.  ***InvalidState***: if the virtual machine is not connected.  ***ToolsUnavailable***: if VMware Tools is not running.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachineshutdownguest"></a>
# **VirtualMachineShutdownGuest**
> void VirtualMachineShutdownGuest (string moId)

Issues a command to the guest operating system asking it to perform a clean shutdown of all services. 

Issues a command to the guest operating system asking it to perform a clean shutdown of all services.  Returns immediately and does not wait for the guest operating system to complete the operation.  ***Required privileges:*** VirtualMachine.Interact.PowerOff 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineShutdownGuestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Issues a command to the guest operating system asking it to perform a clean shutdown of all services. 
                apiInstance.VirtualMachineShutdownGuest(moId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineShutdownGuest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineShutdownGuestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Issues a command to the guest operating system asking it to perform a clean shutdown of all services. 
    apiInstance.VirtualMachineShutdownGuestWithHttpInfo(moId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineShutdownGuestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

void (empty response body)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content  |  -  |
| **500** | ***InvalidPowerState***: if the power state is not powered on.  ***ToolsUnavailable***: if VMware Tools is not running.  ***TaskInProgress***: if the virtual machine is busy.  ***InvalidState***: if the operation cannot be performed because of the virtual machine&#39;s current state. For example, if the virtual machine configuration information is not available.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinestandbyguest"></a>
# **VirtualMachineStandbyGuest**
> void VirtualMachineStandbyGuest (string moId)

Issues a command to the guest operating system asking it to prepare for a suspend operation. 

Issues a command to the guest operating system asking it to prepare for a suspend operation.  Returns immediately and does not wait for the guest operating system to complete the operation.  ***Required privileges:*** VirtualMachine.Interact.Suspend 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineStandbyGuestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Issues a command to the guest operating system asking it to prepare for a suspend operation. 
                apiInstance.VirtualMachineStandbyGuest(moId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineStandbyGuest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineStandbyGuestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Issues a command to the guest operating system asking it to prepare for a suspend operation. 
    apiInstance.VirtualMachineStandbyGuestWithHttpInfo(moId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineStandbyGuestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

void (empty response body)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content  |  -  |
| **500** | ***InvalidPowerState***: if the power state is not powered on.  ***ToolsUnavailable***: if VMware Tools is not running.  ***TaskInProgress***: if the virtual machine is busy.  ***InvalidState***: if the operation cannot be performed because of the virtual machine&#39;s current state. For example, if the virtual machine configuration information is not available.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinestartrecordingtask"></a>
# **VirtualMachineStartRecordingTask**
> ManagedObjectReference VirtualMachineStartRecordingTask (string moId, StartRecordingRequestType startRecordingRequestType)

Initiates a recording session on this virtual machine. 

Deprecated as of vsphere API 5.1.  Initiates a recording session on this virtual machine.  As a side effect, this operation creates a snapshot on the virtual machine, which in turn becomes the current snapshot.  This is an experimental interface that is not intended for use in production code.  ***Required privileges:*** VirtualMachine.Interact.Record 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineStartRecordingTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var startRecordingRequestType = new StartRecordingRequestType(); // StartRecordingRequestType | 

            try
            {
                // Initiates a recording session on this virtual machine. 
                ManagedObjectReference result = apiInstance.VirtualMachineStartRecordingTask(moId, startRecordingRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineStartRecordingTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineStartRecordingTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Initiates a recording session on this virtual machine. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineStartRecordingTaskWithHttpInfo(moId, startRecordingRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineStartRecordingTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **startRecordingRequestType** | [**StartRecordingRequestType**](StartRecordingRequestType.md) |  |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation. The *info.result* property in the *Task* contains the newly created *VirtualMachineSnapshot* associated with the recording on success.  Refers instance of *Task*.  |  -  |
| **500** | ***TaskInProgress***: if the virtual machine is busy.  ***NotSupported***: if the host product does not support record functionality or if the virtual machine does not support this  ***VmConfigIncompatibleForRecordReplay***: if the virtual machine configuration is incompatible for recording.  ***SnapshotFault***: if an error occurs during the snapshot operation. Typically, a more specific fault like MultipleSnapshotsNotSupported is thrown.  ***InvalidName***: if the specified snapshot name is invalid.  ***FileFault***: if there is a problem with creating or accessing one or more files needed for this operation.  ***InvalidPowerState***: if the operation cannot be performed in the current power state of the virtual machine.  ***InvalidState***: if the operation cannot be performed because of the virtual machine&#39;s current state. For example, the virtual machine configuration information is not available.  ***RecordReplayDisabled***: if the record/replay config flag has not been enabled for this virtual machine.  ***HostIncompatibleForRecordReplay***: if the virtual machine is located on a host that does not support record/replay.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinestartreplayingtask"></a>
# **VirtualMachineStartReplayingTask**
> ManagedObjectReference VirtualMachineStartReplayingTask (string moId, StartReplayingRequestType startReplayingRequestType)

Starts a replay session on this virtual machine. 

Deprecated as of vsphere API 5.1.  Starts a replay session on this virtual machine.  As a side effect, this operation updates the current snapshot of the virtual machine.  This is an experimental interface that is not intended for use in production code.  ***Required privileges:*** VirtualMachine.Interact.Replay 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineStartReplayingTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var startReplayingRequestType = new StartReplayingRequestType(); // StartReplayingRequestType | 

            try
            {
                // Starts a replay session on this virtual machine. 
                ManagedObjectReference result = apiInstance.VirtualMachineStartReplayingTask(moId, startReplayingRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineStartReplayingTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineStartReplayingTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Starts a replay session on this virtual machine. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineStartReplayingTaskWithHttpInfo(moId, startReplayingRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineStartReplayingTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **startReplayingRequestType** | [**StartReplayingRequestType**](StartReplayingRequestType.md) |  |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation.  Refers instance of *Task*.  |  -  |
| **500** | ***TaskInProgress***: if the virtual machine is busy.  ***NotSupported***: if the host product does not support record/replay functionality or if the virtual machine does not support this capability.  ***InvalidArgument***: if replaySnapshot is not a valid snapshot associated with a recorded session on this virtual machine.  ***SnapshotFault***: if an error occurs during the snapshot operation. Typically, a more specific fault like InvalidSnapshotFormat is thrown.  ***FileFault***: if there is a problem with creating or accessing one or more files needed for this operation.  ***VmConfigIncompatibleForRecordReplay***: if the virtual machine configuration is incompatible for replaying.  ***InvalidPowerState***: if the operation cannot be performed in the current power state of the virtual machine.  ***InvalidState***: if the operation cannot be performed because of the virtual machine&#39;s current state. For example, the virtual machine configuration information is not available.  ***NotFound***: if replaySnapshot is no longer present.  ***RecordReplayDisabled***: if the record/replay config flag has not been enabled for this virtual machine.  ***HostIncompatibleForRecordReplay***: if the virtual machine is located on a host that does not support record/replay.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinestoprecordingtask"></a>
# **VirtualMachineStopRecordingTask**
> ManagedObjectReference VirtualMachineStopRecordingTask (string moId)

Stops a currently active recording session on this virtual machine. 

Deprecated as of vsphere API 5.1.  Stops a currently active recording session on this virtual machine.  This is an experimental interface that is not intended for use in production code.  ***Required privileges:*** VirtualMachine.Interact.Record 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineStopRecordingTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Stops a currently active recording session on this virtual machine. 
                ManagedObjectReference result = apiInstance.VirtualMachineStopRecordingTask(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineStopRecordingTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineStopRecordingTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Stops a currently active recording session on this virtual machine. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineStopRecordingTaskWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineStopRecordingTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation.  Refers instance of *Task*.  |  -  |
| **500** | ***TaskInProgress***: if the virtual machine is busy.  ***NotSupported***: if the host product does not support record/replay functionality or if the virtual machine does not support this capability.  ***SnapshotFault***: if an error occurs during the snapshot operation. Typically, a more specific fault like InvalidSnapshotFormat is thrown.  ***FileFault***: if there is a problem with creating or accessing one or more files needed for this operation.  ***InvalidPowerState***: if the operation cannot be performed in the current power state of the virtual machine.  ***InvalidState***: if the operation cannot be performed because of the virtual machine&#39;s current state. For example, the virtual machine does not have an active recording session.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinestopreplayingtask"></a>
# **VirtualMachineStopReplayingTask**
> ManagedObjectReference VirtualMachineStopReplayingTask (string moId)

Stops a replay session on this virtual machine. 

Deprecated as of vsphere API 5.1.  Stops a replay session on this virtual machine.  This is an experimental interface that is not intended for use in production code.  ***Required privileges:*** VirtualMachine.Interact.Replay 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineStopReplayingTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Stops a replay session on this virtual machine. 
                ManagedObjectReference result = apiInstance.VirtualMachineStopReplayingTask(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineStopReplayingTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineStopReplayingTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Stops a replay session on this virtual machine. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineStopReplayingTaskWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineStopReplayingTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation.  Refers instance of *Task*.  |  -  |
| **500** | ***TaskInProgress***: if the virtual machine is busy.  ***NotSupported***: if the host product does not support record/replay functionality or if the virtual machine does not support this capability.  ***SnapshotFault***: if an error occurs during the snapshot operation. Typically, a more specific fault like InvalidSnapshotFormat is thrown.  ***FileFault***: if there is a problem with creating or accessing one or more files needed for this operation.  ***InvalidPowerState***: if the operation cannot be performed in the current power state of the virtual machine.  ***InvalidState***: if the operation cannot be performed because of the virtual machine&#39;s current state. For example, the virtual machine does not have an active recording session.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachinesuspendvmtask"></a>
# **VirtualMachineSuspendVMTask**
> ManagedObjectReference VirtualMachineSuspendVMTask (string moId)

Suspends execution in this virtual machine. 

Suspends execution in this virtual machine.  ***Required privileges:*** VirtualMachine.Interact.Suspend 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineSuspendVMTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Suspends execution in this virtual machine. 
                ManagedObjectReference result = apiInstance.VirtualMachineSuspendVMTask(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineSuspendVMTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineSuspendVMTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Suspends execution in this virtual machine. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineSuspendVMTaskWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineSuspendVMTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation.  Refers instance of *Task*.  |  -  |
| **500** | ***InvalidPowerState***: if the power state is not poweredOn.  ***TaskInProgress***: if the virtual machine is busy.  ***NotSupported***: if the virtual machine is marked as a template.  ***InvalidState***: if the operation cannot be performed because of the virtual machine&#39;s current state. For example, if the virtual machine configuration information is not available.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachineterminatefaulttolerantvmtask"></a>
# **VirtualMachineTerminateFaultTolerantVMTask**
> ManagedObjectReference VirtualMachineTerminateFaultTolerantVMTask (string moId, TerminateFaultTolerantVMRequestType? terminateFaultTolerantVMRequestType = null)

Terminates the specified secondary virtual machine in a fault tolerant group. 

Terminates the specified secondary virtual machine in a fault tolerant group.  This can be used to test fault tolerance on a given virtual machine, and should be used with care.  ***Required privileges:*** VirtualMachine.Interact.TerminateFaultTolerantVM 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineTerminateFaultTolerantVMTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var terminateFaultTolerantVMRequestType = new TerminateFaultTolerantVMRequestType?(); // TerminateFaultTolerantVMRequestType? |  (optional) 

            try
            {
                // Terminates the specified secondary virtual machine in a fault tolerant group. 
                ManagedObjectReference result = apiInstance.VirtualMachineTerminateFaultTolerantVMTask(moId, terminateFaultTolerantVMRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineTerminateFaultTolerantVMTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineTerminateFaultTolerantVMTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Terminates the specified secondary virtual machine in a fault tolerant group. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineTerminateFaultTolerantVMTaskWithHttpInfo(moId, terminateFaultTolerantVMRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineTerminateFaultTolerantVMTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **terminateFaultTolerantVMRequestType** | [**TerminateFaultTolerantVMRequestType?**](TerminateFaultTolerantVMRequestType?.md) |  | [optional]  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation.  Refers instance of *Task*.  |  -  |
| **500** | ***VmFaultToleranceIssue***: if any error is encountered with the fault tolerance configuration of the virtual machine. Typically, a more specific fault like InvalidOperationOnSecondaryVm is thrown.  ***TaskInProgress***: if the virtual machine is busy.  ***InvalidState***: if the host is in maintenance mode or if the virtual machine&#39;s configuration information is not available.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachineterminatevm"></a>
# **VirtualMachineTerminateVM**
> void VirtualMachineTerminateVM (string moId)

Do an immediate power off of a VM. 

Do an immediate power off of a VM.  This API issues a SIGKILL to the vmx process of the VM. Pending synchronous I/Os may not be written out before the vmx process dies depending on accessibility of the datastore.  ***Required privileges:*** VirtualMachine.Interact.PowerOff 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineTerminateVMExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Do an immediate power off of a VM. 
                apiInstance.VirtualMachineTerminateVM(moId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineTerminateVM: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineTerminateVMWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Do an immediate power off of a VM. 
    apiInstance.VirtualMachineTerminateVMWithHttpInfo(moId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineTerminateVMWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

void (empty response body)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content  |  -  |
| **500** | ***NotSupported***: if this operation is not supported.  ***InvalidState***: if the VM is not powered on or another issue prevents the operation from being performed.  ***TaskInProgress***: if the virtual machine is busy.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachineturnofffaulttoleranceforvmtask"></a>
# **VirtualMachineTurnOffFaultToleranceForVMTask**
> ManagedObjectReference VirtualMachineTurnOffFaultToleranceForVMTask (string moId)

Removes all secondary virtual machines associated with the fault tolerant group and turns off protection for this virtual machine. 

Removes all secondary virtual machines associated with the fault tolerant group and turns off protection for this virtual machine.  This operation can only be invoked from the primary virtual machine in the group.  ***Required privileges:*** VirtualMachine.Interact.TurnOffFaultTolerance 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineTurnOffFaultToleranceForVMTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Removes all secondary virtual machines associated with the fault tolerant group and turns off protection for this virtual machine. 
                ManagedObjectReference result = apiInstance.VirtualMachineTurnOffFaultToleranceForVMTask(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineTurnOffFaultToleranceForVMTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineTurnOffFaultToleranceForVMTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Removes all secondary virtual machines associated with the fault tolerant group and turns off protection for this virtual machine. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineTurnOffFaultToleranceForVMTaskWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineTurnOffFaultToleranceForVMTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation.  Refers instance of *Task*.  |  -  |
| **500** | ***VmFaultToleranceIssue***: if any error is encountered with the fault tolerance configuration of the virtual machine. Typically, a more specific fault like InvalidOperationOnSecondaryVm is thrown.  ***TaskInProgress***: if the virtual machine is busy.  ***InvalidState***: if the host is in maintenance mode or if the virtual machine&#39;s configuration information is not available.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachineunmounttoolsinstaller"></a>
# **VirtualMachineUnmountToolsInstaller**
> void VirtualMachineUnmountToolsInstaller (string moId)

Unmounts VMware Tools installer CD. 

Unmounts VMware Tools installer CD.  ***Required privileges:*** VirtualMachine.Interact.ToolsInstall 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineUnmountToolsInstallerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Unmounts VMware Tools installer CD. 
                apiInstance.VirtualMachineUnmountToolsInstaller(moId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineUnmountToolsInstaller: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineUnmountToolsInstallerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unmounts VMware Tools installer CD. 
    apiInstance.VirtualMachineUnmountToolsInstallerWithHttpInfo(moId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineUnmountToolsInstallerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

void (empty response body)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content  |  -  |
| **500** | ***InvalidState***: if the virtual machine is not running, VMware Tools is not running or the VMware Tools CD is already mounted.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachineunregistervm"></a>
# **VirtualMachineUnregisterVM**
> void VirtualMachineUnregisterVM (string moId)

Removes this virtual machine from the inventory without removing any of the virtual machine's files on disk. 

Removes this virtual machine from the inventory without removing any of the virtual machine's files on disk.  All high-level information stored with the management server (ESX Server or VirtualCenter) is removed, including information such as statistics, resource pool association, permissions, and alarms.  Use the Folder.RegisterVM method to recreate a VirtualMachine object from the set of virtual machine files by passing in the path to the configuration file. However, the VirtualMachine managed object that results typically has different objects ID and may inherit a different set of permissions.  ***Required privileges:*** VirtualMachine.Inventory.Unregister 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineUnregisterVMExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Removes this virtual machine from the inventory without removing any of the virtual machine's files on disk. 
                apiInstance.VirtualMachineUnregisterVM(moId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineUnregisterVM: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineUnregisterVMWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Removes this virtual machine from the inventory without removing any of the virtual machine's files on disk. 
    apiInstance.VirtualMachineUnregisterVMWithHttpInfo(moId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineUnregisterVMWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

void (empty response body)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content  |  -  |
| **500** | ***TaskInProgress***: if the virtual machine is busy.  ***InvalidPowerState***: if the virtual machine is powered on.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachineupgradetoolstask"></a>
# **VirtualMachineUpgradeToolsTask**
> ManagedObjectReference VirtualMachineUpgradeToolsTask (string moId, UpgradeToolsRequestType? upgradeToolsRequestType = null)

Begins the tools upgrade process. 

Begins the tools upgrade process.  To monitor the status of the tools install, clients should check the tools status, *GuestInfo.toolsVersionStatus* and *GuestInfo.toolsRunningStatus*.  ***Required privileges:*** VirtualMachine.Interact.ToolsInstall 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineUpgradeToolsTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var upgradeToolsRequestType = new UpgradeToolsRequestType?(); // UpgradeToolsRequestType? |  (optional) 

            try
            {
                // Begins the tools upgrade process. 
                ManagedObjectReference result = apiInstance.VirtualMachineUpgradeToolsTask(moId, upgradeToolsRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineUpgradeToolsTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineUpgradeToolsTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Begins the tools upgrade process. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineUpgradeToolsTaskWithHttpInfo(moId, upgradeToolsRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineUpgradeToolsTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **upgradeToolsRequestType** | [**UpgradeToolsRequestType?**](UpgradeToolsRequestType?.md) |  | [optional]  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation.  Refers instance of *Task*.  |  -  |
| **500** | ***InvalidState***: if the virtual machine is not running or is suspended.  ***NotSupported***: if upgrading tools is not supported.  ***TaskInProgress***: if an upgrade is already taking place.  ***VmToolsUpgradeFault***: if the upgrade failed.  ***ToolsUnavailable***: if VMware Tools is not running.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="virtualmachineupgradevmtask"></a>
# **VirtualMachineUpgradeVMTask**
> ManagedObjectReference VirtualMachineUpgradeVMTask (string moId, UpgradeVMRequestType? upgradeVMRequestType = null)

Upgrades this virtual machine's virtual hardware to the latest revision that is supported by the virtual machine's current host. 

Upgrades this virtual machine's virtual hardware to the latest revision that is supported by the virtual machine's current host.  ***Required privileges:*** VirtualMachine.Config.UpgradeVirtualHardware 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class VirtualMachineUpgradeVMTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VirtualMachineApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var upgradeVMRequestType = new UpgradeVMRequestType?(); // UpgradeVMRequestType? |  (optional) 

            try
            {
                // Upgrades this virtual machine's virtual hardware to the latest revision that is supported by the virtual machine's current host. 
                ManagedObjectReference result = apiInstance.VirtualMachineUpgradeVMTask(moId, upgradeVMRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineUpgradeVMTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualMachineUpgradeVMTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upgrades this virtual machine's virtual hardware to the latest revision that is supported by the virtual machine's current host. 
    ApiResponse<ManagedObjectReference> response = apiInstance.VirtualMachineUpgradeVMTaskWithHttpInfo(moId, upgradeVMRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualMachineApi.VirtualMachineUpgradeVMTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **upgradeVMRequestType** | [**UpgradeVMRequestType?**](UpgradeVMRequestType?.md) |  | [optional]  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation.  Refers instance of *Task*.  |  -  |
| **500** | ***InvalidPowerState***: if the power state is not poweredOff.  ***TaskInProgress***: if the virtual machine is busy.  ***AlreadyUpgraded***: if the virtual machine&#39;s hardware is already up-to-date.  ***NoDiskFound***: if no virtual disks are attached to this virtual machine.  ***InvalidState***: if the host is in maintenance mode, if an invalid version string is specified, or if the virtual machine is in a state in which the operation cannot be performed. For example, if the configuration information is not available.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

