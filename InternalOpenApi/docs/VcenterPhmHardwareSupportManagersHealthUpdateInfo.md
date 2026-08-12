# Vcenter.Automation.OpenApi.Model.VcenterPhmHardwareSupportManagersHealthUpdateInfo
The Vcenter.Phm.HardwareSupportManagers.HealthUpdateInfo schema defines a type of health update to be supported.  This schema was added in __vSphere API 8.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier  This property was added in __vSphere API 8.0.3.0__. | 
**Description** | **string** | Message key for the message that provides important information about the health update info.  This property was added in __vSphere API 8.0.3.0__. | 
**Severity** | **string** | Severity  Possible values:   - &#x60;CRITICAL&#x60;: Critical severity   - &#x60;WARNING&#x60;: Warning severity   - &#x60;INFO&#x60;: Info severity   For more information see: *Vcenter.Phm.HardwareSupportManagers.HealthUpdateInfoSeverity*.  This property was added in __vSphere API 8.0.3.0__. | 
**Purpose** | **string** | Functional purpose category  Possible values:   - &#x60;FAILURE&#x60;: Indicates failure of a hardware component.   - &#x60;PREDICTIVE_FAILURE&#x60;: Indicates predictive failure of a hardware component.   - &#x60;SOFTWARE_INCOMPATIBILITY&#x60;: Indicates software incompatibility.   - &#x60;SECURITY_INFORMATION&#x60;: Indicates security related information.   - &#x60;HEALTH_STATISTIC&#x60;: Indicates health statistic information about a hardware component.   - &#x60;MISCELLANEOUS&#x60;: Indicates unclassified purpose category.   For more information see: *Vcenter.Phm.HardwareSupportManagers.HealthUpdateInfoPurpose*.  This property was added in __vSphere API 8.0.3.0__. | 
**ComponentCategory** | **string** | Target component category  Possible values:   - &#x60;COMPUTE&#x60;: Target component is part of compute resources.   - &#x60;MEMORY&#x60;: Target component is part of memory resources.   - &#x60;STORAGE&#x60;: Target component is part of storage resources.   - &#x60;NETWORK&#x60;: Target component is part of network resources.   - &#x60;BOOT&#x60;: Target component is part of boot drives.   - &#x60;MISCELLANEOUS&#x60;: Target component is something else other than the above categories.   For more information see: *Vcenter.Phm.HardwareSupportManagers.HealthUpdateInfoComponentCategory*.  This property was added in __vSphere API 8.0.3.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

