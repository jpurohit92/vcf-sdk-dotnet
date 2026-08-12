# Vcenter.ViJson.OpenApi.Model.HostSystemInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vendor** | **string** | Hardware vendor identification.  | 
**Model** | **string** | System model identification.  | 
**Family** | **string** | System family identification.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 
**Uuid** | **string** | Hardware BIOS identification.  | 
**OtherIdentifyingInfo** | [**List&lt;HostSystemIdentificationInfo&gt;**](HostSystemIdentificationInfo.md) | Other System identification information.  This information may be vendor specific  | [optional] 
**SerialNumber** | **string** |  | [optional] 
**QualifiedName** | [**List&lt;HostQualifiedName&gt;**](HostQualifiedName.md) | List of qualified names used to identify the host in a specific context.  Unlike the other types of system identification information, these can potentially change as a result of configuration.  ***Since:*** vSphere API Release 7.0.3.0  | [optional] 
**VvolHostNQN** | [**HostQualifiedName**](HostQualifiedName.md) | NVMe qualified name used by Vvol.  A unique name, assigned to each host used by Vvol. Obtained through vmkctl storage control path while fetching the NVMe info.  ***Since:*** vSphere API Release 8.0.0.0  | [optional] 
**VvolHostId** | **string** | Host id used by Vvol.  The hostd id, obtained through vmkctl storage control path while fetching the NVMe info.  ***Since:*** vSphere API Release 8.0.0.0  | [optional] 
**BootCommandLine** | **string** | Command line string to identify different boot options used for host.  Example of different boot options are: - \&quot;runweasel\&quot;: \&quot;System is booted for weasel installation\&quot; - \&quot;ks\&quot;: \&quot;System is booted for kickstart installation\&quot;    ***Since:*** vSphere API Release 8.0.3.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

