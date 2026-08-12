# Vcenter.ViJson.OpenApi.Model.VirtualNVMEController

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BusNumber** | **int** | Bus number associated with this controller.  | 
**Device** | **List&lt;int&gt;** | List of devices currently controlled by this controller.  Each entry contains the *VirtualDevice.key* property of the corresponding device object.  | [optional] 
**SharedBus** | **string** | Mode for sharing the SCSI bus.  The modes are physicalSharing, and noSharing. See the *Sharing* data object type for an explanation of these modes.  ***Since:*** vSphere API Release 8.0.2.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

