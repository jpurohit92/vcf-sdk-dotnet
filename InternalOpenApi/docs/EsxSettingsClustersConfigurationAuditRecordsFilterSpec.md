# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersConfigurationAuditRecordsFilterSpec
The Esx.Settings.Clusters.Configuration.AuditRecords.FilterSpec schema contains properties used to filter the audit records. If multiple properties are specified, only records matching all of the properties match the filter.  This schema was added in __vSphere API 8.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TimeDuration** | **string** | List of audit records that match Esx.Settings.Clusters.Configuration.AuditRecords.FilterSpec.Timeframe, valid values are Timeframe. i.e. For ex: records within last 3 months.  Possible values:   - &#x60;THREE_MONTHS&#x60;: To indicate last 3 months audit records   - &#x60;SIX_MONTHS&#x60;: To indicate last 6 months audit records   - &#x60;YEAR&#x60;: To indicate last 1 year audit records   - &#x60;CUSTOM&#x60;: To indicate custom time frame for getting audit records. Users can specify start time and end time   For more information see: *Esx.Settings.Clusters.Configuration.AuditRecords.FilterSpec.Timeframe*.  This property was added in __vSphere API 8.0.2.0__.  If missing or &#x60;null&#x60; or empty, last one year audit records match the filter. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

