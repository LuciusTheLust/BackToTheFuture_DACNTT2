import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'OrderService',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44329/',
    redirectUri: baseUrl,
    clientId: 'OrderService_App',
    responseType: 'code',
    scope: 'offline_access OrderService',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44329',
      rootNamespace: 'OrderService',
    },
  },
} as Environment;
