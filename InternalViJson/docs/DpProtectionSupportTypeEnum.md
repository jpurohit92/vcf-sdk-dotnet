# Vcenter.ViJson.OpenApi.Model.DpProtectionSupportTypeEnum
Indicates if the cluster supports vSphere Data Protection.  Possible values: - `supported`: The LWD VAIO filter is installed on all hosts in the cluster.      The cluster supports data protection. - `partially_supported`: The LWD VAIO filter is installed on some hosts in the cluster.      If protection in enabled on an entity, it cannot migrate to other nodes in the cluster until all the nodes have the filter installed. - `not_supported`: The LWD VAIO filter is not installed on any of the hosts in the cluster.      Entities cannot be protected in this cluster. - `ProtectionSupportType_unknown`: Represents value when the lower version client cannot recognize the enum value. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

