# Vcenter.ViJson.OpenApi.Model.VmConfigInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Product** | [**List&lt;VAppProductInfo&gt;**](VAppProductInfo.md) | Information about the package content.  | [optional] 
**Property** | [**List&lt;VAppPropertyInfo&gt;**](VAppPropertyInfo.md) | List of properties  | [optional] 
**IpAssignment** | [**VAppIPAssignmentInfo**](VAppIPAssignmentInfo.md) | IP assignment policy and DHCP support configuration.  | 
**Eula** | **List&lt;string&gt;** | End User Licenses Agreements.  | [optional] 
**OvfSection** | [**List&lt;VAppOvfSectionInfo&gt;**](VAppOvfSectionInfo.md) | List of uninterpreted OVF meta-data sections.  | [optional] 
**OvfEnvironmentTransport** | **List&lt;string&gt;** | List the transports to use for properties.  Supported values are: iso and com.vmware.guestInfo.  | [optional] 
**InstallBootRequired** | **bool** | Specifies whether the VM needs an initial boot before the deployment is complete.  Not relevant for vApps. This means that the value is always false when reading the configuration and is ignored when setting the configuration.  If a vApp requires an install boot (because one of its VMs does), this is visible on the *VirtualAppSummary.installBootRequired* field of the vApp.  | 
**InstallBootStopDelay** | **int** | Specifies the delay in seconds to wait for the VM to power off after the initial boot (used only if installBootRequired is true).  A value of 0 means wait forever.  Not relevant for vApps. This means that the value is always false when reading the configuration and is ignored when setting the configuration.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

