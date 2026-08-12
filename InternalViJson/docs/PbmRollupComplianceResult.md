# Vcenter.ViJson.OpenApi.Model.PbmRollupComplianceResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OldestCheckTime** | **DateTime** | Indicates the earliest time that compliance was checked for any of the entities in the rollup compliance check.  The compliance check time for a single entity is represented in the *PbmComplianceResult*.*PbmComplianceResult.checkTime* property. If the *PbmComplianceResult.checkTime* property is unset for any of the objects in the &lt;code&gt;results&lt;/code&gt; array, the &lt;code&gt;oldestCheckTime&lt;/code&gt; property will be unset.  | 
**Entity** | [**PbmServerObjectRef**](PbmServerObjectRef.md) | Virtual machine for which the rollup compliance was checked.  | 
**OverallComplianceStatus** | **string** | Overall compliance status of the virtual machine and its virtual disks.  &lt;code&gt;overallComplianceStatus&lt;/code&gt; is a string value that corresponds to one of the *PbmComplianceResult*.*PbmComplianceResult.complianceStatus* values.  The overall compliance status is determined by the following rules, applied in the order listed: - If all the entities are &lt;code&gt;compliant&lt;/code&gt;, the overall status is   &lt;code&gt;compliant&lt;/code&gt;. - Else if any entity&#39;s status is &lt;code&gt;outOfDate&lt;/code&gt;, the overall status is   &lt;code&gt;outOfDate&lt;/code&gt;. - Else if any entity&#39;s status is &lt;code&gt;nonCompliant&lt;/code&gt;, the overall status is   &lt;code&gt;nonCompliant&lt;/code&gt;. - Else if any entity&#39;s status is &lt;code&gt;unknown&lt;/code&gt;, the overall status is   &lt;code&gt;unknown&lt;/code&gt;. - Else if any entity&#39;s status is &lt;code&gt;notApplicable&lt;/code&gt;, the overall status is   &lt;code&gt;notApplicable&lt;/code&gt;.  | 
**OverallComplianceTaskStatus** | **string** | Overall compliance task status of the virtual machine and its virtual disks.  &lt;code&gt;overallComplianceTaskStatus&lt;/code&gt; is a string value that corresponds to one of the *PbmComplianceResult*. *PbmComplianceResult.complianceTaskStatus* values.  | [optional] 
**Result** | [**List&lt;PbmComplianceResult&gt;**](PbmComplianceResult.md) | Individual compliance results that make up the rollup.  | [optional] 
**ErrorCause** | [**List&lt;MethodFault&gt;**](MethodFault.md) | This property is set if the overall compliance task fails with some error.  This property indicates the causes of error. If there are multiple failures, it stores these failure in this array.  | [optional] 
**ProfileMismatch** | **bool** | Deprecated as of vSphere 2016, use *PbmRollupComplianceResult.overallComplianceStatus* to know if profile mismatch has occurred. If overallComplianceStatus value is outOfDate, it means profileMismatch has occurred.  True if and only if *PbmComplianceResult*.  *PbmComplianceResult.mismatch* is true for at least one entity in the rollup compliance check.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

