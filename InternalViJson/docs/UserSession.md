# Vcenter.ViJson.OpenApi.Model.UserSession

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | A unique identifier for this session, also known as the session ID.  | 
**UserName** | **string** | The user name represented by this session.  | 
**FullName** | **string** | The full name of the user, if available.  | 
**LoginTime** | **DateTime** | Timestamp when the user last logged on to the server.  | 
**LastActiveTime** | **DateTime** | Timestamp when the user last executed a command.  | 
**Locale** | **string** | The locale for the session used for data formatting and preferred for messages.  | 
**MessageLocale** | **string** | The locale used for messages for the session.  If there are no localized messages for the user-specified locale, then the server determines this locale.  | 
**ExtensionSession** | **bool** | Whether or not this session belongs to a VC Extension.  | 
**IpAddress** | **string** | The client identity.  It could be IP address, or pipe name depended on client binding  | 
**UserAgent** | **string** | The name of user agent or application  | 
**CallCount** | **long** | Number of API invocations since the session started  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

