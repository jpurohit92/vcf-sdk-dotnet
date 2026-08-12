# Vcenter.ViJson.OpenApi.Model.VsanEncryptionHealthSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hostname** | **string** | Hostname/IP of host which runs the encryption health check.  | [optional] 
**EncryptionInfo** | [**VsanHostEncryptionInfo**](VsanHostEncryptionInfo.md) | Encryption information on the host, including encryption enablement state, Key Encryption Key id, Data Encryption generation number, servers certificate thumbprints, client certificate thumbprint, client key hash, Key Management Servers information.  The encryption information on host will be used for checking consistency with the cluster configuration on vCenter side.  | [optional] 
**OverallKmsHealth** | **string** | The overall KMS cluster health status on the ESXi host.  All of possible value are \&quot;green\&quot;, \&quot;red\&quot; and \&quot;yellow\&quot;. \&quot;green\&quot;: If all KMS health status are \&quot;green\&quot;. \&quot;red\&quot;: If all KMS health status is \&quot;red\&quot;. \&quot;yellow\&quot;: If at least one KMS health status is \&quot;green\&quot;.  | 
**KmsHealth** | [**List&lt;VsanKmsHealth&gt;**](VsanKmsHealth.md) | Key Management Servers connection health check result on the host.  | [optional] 
**EncryptionIssues** | **List&lt;string&gt;** | Host inconsistent encryption issues against cluster configuration.  This field can only be set from vCenter side.  See also *VsanEncryptionIssue_enum*.  | [optional] 
**DiskResults** | [**List&lt;VsanDiskEncryptionHealth&gt;**](VsanDiskEncryptionHealth.md) | Disk encryption health results on the host.  This field can only be set from vCenter side. See *VsanDiskEncryptionHealth*.  | [optional] 
**Error** | [**MethodFault**](MethodFault.md) | If error is set, it means that collection of encryption information failed on this host.  | [optional] 
**AesniEnabled** | **bool** | The host CPU AES-NI instruction set enabled state.  If AES-NI was disabled, the software encryption would be significantly slower than AES-NI.  | [optional] 
**InconsistentlyEncryptedObjectCount** | **long** | The number of encrypted objects whose encryption key is inconsistent with the host encryption configuration, 0 means all objects are consistent.  | [optional] 
**HostEncryptionDekId** | **string** | Per host object encryption dek id.  | [optional] 
**KekVerifierHealth** | **bool** | The host Kek Verifier health state, &#39;True&#39; means the host kek verifier has not changed and is healthy, &#39;False&#39; means the the host kek verifier has changed and is not healthy  | [optional] 
**DekVerifierHealth** | **bool** | The host Dek Verifier health state, &#39;True&#39; means the host dek verifier has not changed and is healthy, &#39;False&#39; means the the host dek verifier has changed and is not healthy  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

