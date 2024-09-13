export type PortfolioGet = {
  id: number;
  symbol: string;
  comnayName: string;
  purchase: number;
  lastDiv: number;
  industry: string;
  marketCap: number;
  comments: any;
};

export type PortfolioPost = {
  symbol: string;
};
