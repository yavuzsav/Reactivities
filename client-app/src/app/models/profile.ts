export interface IProfile {
  displayName: string;
  userName: string;
  boi: string;
  image: string;
  photos: IPhoto[];
}

export interface IPhoto {
  id: string;
  url: string;
  isMain: boolean;
}
