# Vcenter.ViJson.OpenApi.Model.ClusterSlotPolicy
The base class *ClusterSlotPolicy* is used for specifying how the slot size is to be computed for the failover level HA admission control policy.  By default, vSphere HA defines the slot size using the largest memory and cpu reservations of any powered on virtual machine in the cluster. Subclasses of this class define various policies to modify how the slot size is chosen to prevent outlier virtual machines (i.e. those with much larger reservations than the average) from skewing the slot size. If such a policy is chosen, outlier virtual machines will use multiple slots. Using such a policy introduces a risk that vSphere HA will be unable to failover these virtual machines because of resource fragmentation. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

