export const getSetting = (key: string): string => {
    const value: string | null = process.env[key] || null;
    if (value === null) console.error("Missing config key", key);
    return value || "";
  };
  
  export const appSettings = {
    DustinApiUrl: getSetting("REACT_APP_API_KEY"),
  };
  