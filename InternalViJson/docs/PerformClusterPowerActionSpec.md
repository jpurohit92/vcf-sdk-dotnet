# Vcenter.ViJson.OpenApi.Model.PerformClusterPowerActionSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TargetPowerStatus** | **string** | Specify the target vim.cluster.ClusterPowerStatus.  If the spec is applied on VC, only clusterPoweredOn and clusterPoweredOff are allowed. If the spec is applied on host with isOrchestration set to true, only clusterPoweredOn and clusterPoweredOff are allowed and initialPowerStatus must be set. If the spec is applied on host with isOrchestration set to false, only host level status are allowed as following: vsanMemberShipUpdateDisabled, vsanDOMPauseAllCCPsSet, hostsInMM, hostsPoweredOff, hostsOutOfMM, vsanMemberShipUpdateEnabled, vsanDOMPauseAllCCPsUnset.  See also *ClusterPowerStatus_enum*.  | 
**IsOrchestration** | **bool** | Note this only works in a host level API call to indicate whether this call applies the orchestration host logic or not.  If isOrchestration is True, the host coordinates all other hosts in the cluster to take power action. Otherwise, it executes each step on the host itself.  | [optional] 
**InitialPowerStatus** | **string** | Note this only works in an orchestration host level API call to indicate which power action item step is to begin with.  See also *ClusterPowerStatus_enum*.  | [optional] 
**PowerOffReason** | **string** | Provide the power off reason.  It should be less than 512 characters in length.  | [optional] 
**InfraVMs** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | The infrastructure VMs that will be force to power off during the power off workflow and will be automatically powered on.  This only works in a vc level API call and is ignored in the host level API call.  Refers instances of *VirtualMachine*.  | [optional] 
**InfraVMUuids** | **List&lt;string&gt;** | The uuid of infrastructure VMs that will be force to power off during the power off workflow and will be automatically powered on.  This only works in a host level API call and is ignored in the vc level API call.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

