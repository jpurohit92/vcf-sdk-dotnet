# Vcenter.ViJson.OpenApi.Model.HttpNfcLeaseDeviceUrl

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The immutable identifier for the device.  This is set for both import/export leases.  | 
**ImportKey** | **string** | Identifies the device based on the names in an ImportSpec.  This is only set for import leases.  | 
**Url** | **string** | The URL to use to upload/download the device content.  The returned url contains either an IP address, a hostname or a \&quot;\\*\&quot;. If a \&quot;\\*\&quot; is returned the client must substitutes the \&quot;\\*\&quot; with the hostname or IP address used when connecting to the server. For example if the client connected to \&quot;someHost\&quot; and the device url returned is:       http:// *:somePort/somePath the client must substitute the \&quot;\\*\&quot; with \&quot;someHost\&quot; before use. The resulting url would be:       http://someHost:somePort/somePath The server cannot return a valid hostname or IP address when the client connects via a NAT, a proxy, or when the server is multihomed.  | 
**SslThumbprint** | **string** | SSL thumbprint for the host the URL refers to.  Empty if no SSL thumbprint is available or needed.  | 
**SslCertificate** | **string** | PEM encoded SSL Certificate of the host  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 
**Disk** | **bool** | Optional value to specify if the attached file is a disk in vmdk format.  | [optional] 
**TargetId** | **string** | Id for this target.  This only used for multi-POSTing, where a single HTTP POST is applied to multiple targets.  | [optional] 
**DatastoreKey** | **string** | Key for the datastore this disk is on.  This is used to look up hosts which can be used to multi-POST disk contents, in the host map of the lease.  | [optional] 
**FileSize** | **long** | Specifies the size of the file backing for this device.  This property is only set for non-disk file backings.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

