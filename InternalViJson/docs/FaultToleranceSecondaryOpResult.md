# Vcenter.ViJson.OpenApi.Model.FaultToleranceSecondaryOpResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The Secondary VirtualMachine  Refers instance of *VirtualMachine*.  | 
**PowerOnAttempted** | **bool** | Whether an attempt was made to power on the secondary.  If an attempt was made, *FaultToleranceSecondaryOpResult.powerOnResult* will report the status of this attempt.  | 
**PowerOnResult** | [**ClusterPowerOnVmResult**](ClusterPowerOnVmResult.md) | The powerOnResult property reports the outcome of powering on the Secondary VirtualMachine if a power on was required.  A power on will be attempted if the Primary Virtual Machine is powered on when the operation is performed. This object is only reported if *FaultToleranceSecondaryOpResult.powerOnAttempted* is true. If the outcome of the power-on attempt is not successful, the returned *ClusterPowerOnVmResult* object will include an instance of *ClusterNotAttemptedVmInfo* whereas if the attempt was successful, then an instance of *ClusterAttemptedVmInfo* is returned. When *ClusterAttemptedVmInfo* is returned, its *ClusterAttemptedVmInfo.task* property is only set if the cluster is a HA-only cluster.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

