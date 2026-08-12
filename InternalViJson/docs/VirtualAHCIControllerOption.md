# Vcenter.ViJson.OpenApi.Model.VirtualAHCIControllerOption
VirtualAHCIControllerOption is the data object that contains the options for an AHCI SATA controller. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NumSATADisks** | [**IntOption**](IntOption.md) | Three properties (numSATADisks.min, numSATADisks.max, and numSATADisks.defaultValue) define the minimum, maximum, and default number of SATA VirtualDisk instances available at any given time in the SATA controller.  The number of SATA VirtualDisk instances is also limited by the number of available slots in the SATA controller.  | 
**NumSATACdroms** | [**IntOption**](IntOption.md) | Three properties (numSATACdroms.min, numSATACdroms.max, and numSATACdroms.defaultValue) define the minimum, maximum, and default number of SATA VirtualCdrom instances available in the SATA controller.  The number of SATA VirtualCdrom instances is also limited by the number of available slots in the SATA controller.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

