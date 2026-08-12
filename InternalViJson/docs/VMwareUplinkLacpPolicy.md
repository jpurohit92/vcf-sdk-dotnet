# Vcenter.ViJson.OpenApi.Model.VMwareUplinkLacpPolicy

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Inherited** | **bool** | Whether the configuration is set to inherited value.  | 
**Enable** | [**BoolPolicy**](BoolPolicy.md) | The flag to indicate whether or not Link Aggregation Control Protocol is enabled.  It can be set to true if the value of *VMwareDVSConfigInfo.lacpApiVersion* is *singleLag*, else an exception ConflictingConfiguration will be thrown.  | [optional] 
**Mode** | [**StringPolicy**](StringPolicy.md) | The mode of Link Aggregation Control Protocol.  See *VMwareUplinkLacpMode_enum* for valid values.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

