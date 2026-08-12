# Vcenter.ViJson.OpenApi.Model.FileTransferInformation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Attributes** | [**GuestFileAttributes**](GuestFileAttributes.md) | File attributes of the file that is being transferred from the guest.  | 
**Size** | **long** | Total size of the file in bytes.  | 
**Url** | **string** | Specifies the URL to which the user has to send HTTP GET request.  Multiple GET requests cannot be sent to the URL simultaneously. URL will become invalid once a successful GET request is sent.       The host part of the URL is returned as &#39;\\*&#39; if the hostname to be used is the name of the server to which the call was made. For example, if the call is made to esx-svr-1.domain1.com, and the file is available for download from &#x60;https://esx-svr-1.domain1.com/guestFile?id&#x3D;1&amp;token&#x3D;1234&#x60;, the URL returned may be &#x60;https://&amp;#42;/guestFile?id&#x3D;1&amp;token&#x3D;1234&#x60;. The client replaces the asterisk with the server name on which it invoked the call.       The URL is valid only for 10 minutes from the time it is generated. Also, the URL becomes invalid whenever the virtual machine is powered off, suspended or unregistered.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

