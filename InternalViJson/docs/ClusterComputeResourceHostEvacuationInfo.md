# Vcenter.ViJson.OpenApi.Model.ClusterComputeResourceHostEvacuationInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | Candidate host to be put into maintenance mode.  Refers instance of *HostSystem*.  | 
**Action** | [**List&lt;OptionValue&gt;**](OptionValue.md) | Specifies the list of required actions.  Depending on the specified option values passed, additional actions such as ones related to evacuation of specific objects, additional memory reservation or allowing/disallowing certain groups of operations may be taken when entering the desired flavor of maintenance mode. The list of supported options and values may vary based on the version of the ESXi host and Virtual Center.  If unset, a default list of actions will be assumed based on the selected flavor of maintenance mode as specified by the *ClusterComputeResourceMaintenanceInfo.partialMMId* field. See *HostPartialMaintenanceModeId_enum* for further information about individual flavors.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

