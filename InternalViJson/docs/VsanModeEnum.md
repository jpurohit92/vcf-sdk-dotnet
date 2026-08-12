# Vcenter.ViJson.OpenApi.Model.VsanModeEnum
Mode for the vSAN cluster.  If mode is not specified, then vSAN is running in default vSAN mode.  Possible values: - `Mode_None`: Represents the value for vSAN mode not being set.      Any mode can be disabled by setting this value. - `Mode_Compute`: Compute mode for vSAN.      This mode can only be set if vSAN is not enabled on the cluster. To disable this mode, the mode value needs to be set to 'Mode\\_None'. This mode allows the cluster to mount any remote vSAN datastore on this cluster. This cluster acts as a client cluster for the mounted vSAN datastore - `Mode_Storage` - `Mode_Unknown`: Represents the value when the lower version client cannot recognize the enum value 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

